using Inspection_Outcome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace Inspection_Outcome.Controllers
{
    public class SampleScanController : Controller
    {
        private readonly ErpDataContext _dbcontext;

        public SampleScanController(ErpDataContext dbcontext)
        {
            _dbcontext = dbcontext;
            _dbcontext.Database.SetCommandTimeout(180);
        }
        #region SampleSacn Controller{
        // ===============================
        // PAGE LOAD
        // ===============================
        [HttpGet]
        public IActionResult AddSample()
        {
            return View();
        }

        // ===============================
        // BARCODE SCAN
        // Format: "SampleNo-ReqDtlId"
        // Example: "SMP001-42"
        // ===============================
        [HttpGet]
        public IActionResult ScanBarcode(string barcode)
        {
            // ── Basic validation ──
            if (string.IsNullOrWhiteSpace(barcode) || !barcode.Contains("-"))
                return Json(new { success = false, message = "Invalid barcode format" });

            var parts = barcode.Split('-');

            if (parts.Length != 2 || !int.TryParse(parts[1], out int reqDtlId))
                return Json(new { success = false, message = "Invalid barcode ID" });

            // ── DB lookup ──
            var data = (from r in _dbcontext.TblDesignReqDtls
                        join d in _dbcontext.TblDesignReqMsts
                            on r.OrderId equals d.Id
                        where r.Id == reqDtlId
                        select new
                        {
                            SampleNo = parts[0],
                            ReqDtlId = r.Id,
                            CustomerNo = d.CustomerNo,
                            ProjectName = string.IsNullOrEmpty(d.ProjectName)
                                            ? d.CustPono
                                            : d.ProjectName,
                            Quality = r.Qlty,
                            Design = r.DesignName,
                            Matrial = r.Material
                        }).FirstOrDefault();

            if (data == null)
                return Json(new { success = false, message = "Barcode record nahi mila" });

            return Json(new { success = true, data });
        }

        // ===============================
        // SAVE GODOWN ENTRY
        // ===============================
        [HttpPost]
        public IActionResult SaveGodownEntry(TblSampleGodownDtl model)
        {
            // ── Required field checks ──
            if (string.IsNullOrWhiteSpace(model.SampleNo))
                return Json(new { success = false, message = "Pehle sample scan karo" });

            if (string.IsNullOrWhiteSpace(model.GodownNo) ||
                string.IsNullOrWhiteSpace(model.RackNo) ||
                string.IsNullOrWhiteSpace(model.BaleNo))
                return Json(new { success = false, message = "Godown, Rack aur Bale No required hain" });

            // ── Normalize ──
            model.SampleNo = model.SampleNo.Trim();
            model.RackNo = model.RackNo.Trim().ToUpper();
            model.BaleNo = model.BaleNo.Trim();

            // ── Duplicate location check (same Godown+Rack+Bale) ──
            bool duplicateLocation = _dbcontext.TblSampleGodownDtls.Any(x =>
                x.GodownNo == model.GodownNo &&
                x.RackNo == model.RackNo &&
                x.BaleNo == model.BaleNo);

            if (duplicateLocation)
                return Json(new { success = false, message = "Yeh location already occupied hai" });

            // ── Duplicate sample check (same Sample+Rack+Bale) ──
            bool duplicateSample = _dbcontext.TblSampleGodownDtls.Any(x =>
                x.SampleNo == model.SampleNo &&
                x.RackNo == model.RackNo &&
                x.BaleNo == model.BaleNo);

            if (duplicateSample)
                return Json(new { success = false, message = "Yeh sample already store hai" });

            // ── Save ──
            model.EntryBy = "SYSTEM";
            model.EntryByDate = DateTime.Now;

            _dbcontext.TblSampleGodownDtls.Add(model);
            _dbcontext.SaveChanges();

            return Json(new { success = true, message = "Entry save ho gayi" });
        }

        // ===============================
        // GET RECENT ENTRIES (last 20)
        // ===============================
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
    
        #endregion
    }
}

