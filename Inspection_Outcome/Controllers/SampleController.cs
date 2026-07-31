using Inspection_Outcome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Inspection_Outcome.Controllers
{
    public class SampleController : Controller
    {
        private readonly ErpDataContext _dbcontext;

        public SampleController(ErpDataContext dbcontext)
        {
            _dbcontext = dbcontext;
            _dbcontext.Database.SetCommandTimeout(180);
        }

        // ==========================================
        // MANUAL SAMPLE PAGE
        // ==========================================
        [HttpGet]
        public IActionResult CreateManualSample()
        {
            return View();
        }
        public IActionResult Result()
        {
            return View();
        }
        // ==========================================
        // SAMPLE NO LIST
        // ==========================================
        [HttpGet]
        public IActionResult GetSampleNoList()
        {
            var sampleNos = _dbcontext.TblSampleAcks
                .Where(x => x.SampleNo != null)
                .Select(x => x.SampleNo)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            return Json(sampleNos);
        }

        // ==========================================
        // SAMPLE DATA BY SAMPLE NO
        // ==========================================
        [HttpGet]
        public IActionResult GetSampleDataBySampleNo(string sampleNo)
        {
            if (string.IsNullOrWhiteSpace(sampleNo))
                return Json(new { success = false, message = "Invalid Sample No" });

            var list = (from sa in _dbcontext.TblSampleAcks
                        join dtl in _dbcontext.TblDesignReqDtls
                            on sa.Srno equals dtl.SrNo
                        join mst in _dbcontext.TblDesignReqMsts
                            on dtl.OrderId equals mst.Id
                        where sa.SampleNo.ToString() == sampleNo
                        select new
                        {
                            mst.CustomerNo,
                            ProjectName = string.IsNullOrEmpty(mst.ProjectName)
                                ? mst.CustPono
                                : mst.ProjectName,
                            Quality = dtl.Qlty,
                            Design = dtl.DesignName,
                            Material = dtl.Material ?? ""
                        }).ToList();

            if (!list.Any())
                return Json(new { success = false, message = "Sample No not found" });

            return Json(new
            {
                success = true,
                data = new
                {
                    customerNo = list.First().CustomerNo,
                    projectName = list.First().ProjectName,
                    qualities = list.Select(x => x.Quality).Distinct(),
                    designs = list.Select(x => x.Design).Distinct(),
                    materials = list.Select(x => x.Material).Distinct()
                }
            });
        }

        // ==========================================
        // SAVE MANUAL ENTRY
        // ==========================================
        [HttpPost]
        public IActionResult CreateManualSample(TblSampleGodownDtl model)
        {
            var result = SaveEntry(model) as JsonResult;

            if (result != null && result.Value != null)
            {
                dynamic data = result.Value;

                if (data.success == false)
                {
                    TempData["MessageType"] = "warning";
                    TempData["Message"] = data.message;
                    return RedirectToAction("CreateManualSample");
                }
            }

            TempData["MessageType"] = "success";
            TempData["Message"] = "Saved successfully";
            return RedirectToAction("CreateManualSample");
        }

        // ==========================================
        // COMMON SAVE LOGIC
        // ==========================================
        private IActionResult SaveEntry(TblSampleGodownDtl model)
        {
            if (string.IsNullOrWhiteSpace(model.GodownNo) ||
                string.IsNullOrWhiteSpace(model.RackNo) ||
                string.IsNullOrWhiteSpace(model.BaleNo))
            {
                return Json(new
                {
                    success = false,
                    message = "Godown, Rack and Bale are required"
                });
            }

            model.EntryBy = "SYSTEM";
            model.EntryByDate = DateTime.Now;

            try
            {
                _dbcontext.TblSampleGodownDtls.Add(model);
                _dbcontext.SaveChanges();
            }
            catch (DbUpdateException)
            {
                return Json(new
                {
                    success = false,
                    message = "Duplicate Godown / Rack / Bale not allowed"
                });
            }

            return Json(new { success = true });
        }

        // ==========================================
        // SHOW DATA PAGE
        // ==========================================
        [HttpGet]
        public IActionResult ShowSample()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetDataSample()
        {
            var data = _dbcontext.TblSampleGodownDtls
                .OrderByDescending(x => x.Id)
                .Take(20)
                .Select(x => new
                {
                    x.Id,
                    x.SampleNo,
                    x.CustomerNo,
                    x.ProjectName,
                    x.Quality,
                    x.Design,
                    matrial = x.Matrial,
                    x.GodownNo,
                    x.RackNo,
                    x.BaleNo,
                    entryDate = x.EntryByDate
                })
                .ToList();

            return Json(data);
        }

        // ==========================================
        // EDIT PAGE
        // ==========================================
        [HttpGet]
        public IActionResult EditGodown(int id)
        {
            var data = _dbcontext.TblSampleGodownDtls.FirstOrDefault(x => x.Id == id);

            if (data == null)
                return NotFound();

            return View(data);
        }

        // ==========================================
        // UPDATE ENTRY
        // ==========================================
        [HttpPost]
        public IActionResult EditGodown(TblSampleGodownDtl model)
        {
            var dbData = _dbcontext.TblSampleGodownDtls.Find(model.Id);

            if (dbData == null)
                return RedirectToAction("ShowSample");

            dbData.GodownNo = model.GodownNo;
            dbData.RackNo = model.RackNo;
            dbData.BaleNo = model.BaleNo;
            dbData.EntryByUpdateDate = DateTime.Now;

            try
            {
                _dbcontext.SaveChanges();
            }
            catch (DbUpdateException)
            {
                TempData["MessageType"] = "warning";
                TempData["Message"] = "Duplicate location not allowed";
                return RedirectToAction("EditGodown", new { id = model.Id });
            }

            TempData["MessageType"] = "success";
            TempData["Message"] = "Updated successfully";

            return RedirectToAction("ShowSample");
        }

        // ==========================================
        // DELETE
        // ==========================================
        [HttpPost]
        public IActionResult DeleteGodown(int id)
        {
            var record = _dbcontext.TblSampleGodownDtls.Find(id);

            if (record == null)
                return Json(new { success = false });

            _dbcontext.TblSampleGodownDtls.Remove(record);
            _dbcontext.SaveChanges();

            return Json(new { success = true });
        }
    
    }
}
