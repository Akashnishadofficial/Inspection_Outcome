using Inspection_Outcome.Models;
using Microsoft.AspNetCore.Mvc;

namespace Inspection_Outcome.Controllers
{
    public class SampleLableProjController : Controller
    {
        private readonly ErpDataContext _db;

        public SampleLableProjController(ErpDataContext db)
        {
            _db = db;
        }

        // ================= MAIN PAGE =================
        public IActionResult SampleLable()
        {
            ViewBag.SampleNos = _db.TblSampleAcks
                .Where(x => x.SampleNo != null)
                .Select(x => x.SampleNo)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            return View();
        }

        // ================= SAVE LABEL =================
        [HttpPost]
        public IActionResult SaveSampleLabels(List<TblSampleLable> models)
        {
            var selected = models.Where(x => x.IsSelected).ToList();

            int saved = 0;
            int duplicate = 0;

            foreach (var m in selected)
            {
                bool exists = _db.TblSampleLables.Any(x =>
                    x.SampleNo == m.SampleNo &&
                    x.SrNo == m.SrNo &&
                    x.Design == m.Design);

                if (exists)
                {
                    duplicate++;
                    continue;
                }

                m.EntryBy = User.Identity?.Name;
                m.EntryByDate = DateTime.Now;

                _db.TblSampleLables.Add(m);
                saved++;
            }

            _db.SaveChanges();

            if (saved > 0 && duplicate == 0)
            {
                TempData["MsgType"] = "success";
                TempData["Message"] = "Record saved successfully";
            }
            else if (saved == 0 && duplicate > 0)
            {
                TempData["MsgType"] = "warning";
                TempData["Message"] = "Duplicate record already exists";
            }
            else
            {
                TempData["MsgType"] = "info";
                TempData["Message"] = $"Saved: {saved}, Duplicate skipped: {duplicate}";
            }

            return RedirectToAction("SampleLable");
        }

        // ================= PENDING TAB =================
        public IActionResult PendingSampleLable(int sampleNo)
        {
            var data = (from sa in _db.TblSampleAcks
                        join dtl in _db.TblDesignReqDtls
                            on sa.Srno equals dtl.SrNo
                        join mst in _db.TblDesignReqMsts
                            on dtl.OrderId equals mst.Id
                        where sa.SampleNo == sampleNo
                              &&
                              !_db.TblSampleLables.Any(x =>
                                    x.SampleNo == sa.SampleNo &&
                                    x.SrNo == sa.Srno &&
                                    x.Design == dtl.DesignName)
                        select new TblSampleLable
                        {
                            SrNo = sa.Srno,
                            SampleNo = sa.SampleNo,
                            CustomerNo = mst.CustomerNo,
                            ProjectName = string.IsNullOrEmpty(mst.ProjectName)
                                ? mst.CustPono
                                : mst.ProjectName,
                            Quality = dtl.Qlty,
                            SubQuality = dtl.SubQlty,
                            Design = dtl.DesignName,
                            Matrial = dtl.Material,
                            Texture = dtl.Texture,
                            Color = dtl.Color,
                            Uom = dtl.Uom,
                            WdthFt = dtl.WdthFt,
                            WdthInch = dtl.WdthInch,
                            LnthFt = dtl.LnthFt,
                            LnthInch = dtl.LnthInch
                        }).ToList();

            return PartialView("_PendingSampleLable", data); 
        }

        // ================= GENERATED TAB =================
        public IActionResult GeneratedSampleLable(int? sampleNo)
        {
            if (sampleNo == null)
                return PartialView("_GeneratedSampleLable",
                    new List<TblSampleLable>());

            var data = _db.TblSampleLables
                .Where(x => x.SampleNo == sampleNo)
                .OrderByDescending(x => x.Id)
                .ToList();

            return PartialView("_GeneratedSampleLable", data);
        }

        // ================= DELETE =================
        [HttpPost]
        public IActionResult DeleteSampleLable(int id)
        {
            var row = _db.TblSampleLables.Find(id);

            if (row != null)
            {
                _db.TblSampleLables.Remove(row);
                _db.SaveChanges();
            }

            return Ok();
        }

        // ================= EDIT PAGE =================
        public IActionResult EditSampleLable(int id)
        {
            var row = _db.TblSampleLables.Find(id);
            if (row == null) return NotFound();

            return View(row);
        }

        [HttpPost]
        public IActionResult EditSampleLable(TblSampleLable model)
        {
            var row = _db.TblSampleLables.Find(model.Id);
            if (row == null) return NotFound();
            row.Design = model.Design;
            row.SubQuality = model.SubQuality;
            row.Category = model.Category;
            row.ItemCode = model.ItemCode;
            row.Color = model.Color;
            row.Matrial = model.Matrial;
            row.Texture = model.Texture;
            row.UpdateBy = "System";
            row.UpdateByDate = DateTime.Now;
            _db.SaveChanges();

            TempData["Message"] = "Record updated";
            return RedirectToAction("SampleLable");
        }
    
    }
}
