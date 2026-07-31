using Inspection_Outcome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Inspection_Outcome.Controllers
{
    public class PackingController : Controller
    {
        private readonly ErpDataContext _dbcontext;

        public PackingController(ErpDataContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        // ================= MAIN PAGE =================
        public IActionResult IndexPacking()
        {
            var rawDispatch =
                (from m in _dbcontext.TblProductionAcks
                 join d in _dbcontext.TblCarpetDispatches
                     on m.Srno equals d.SrNo
                 where d.Status == "DISPATCHED"
                 select new
                 {
                     m.OrderNo,
                     d.CustomerCode,
                     d.ShipMode,
                     d.Pcs,
                     d.DispatchDate
                 }).ToList();

            var packedSummary = _dbcontext.TblPackings.GroupBy(x => x.OrderNo)
                .Select(g => new
                {
                    OrderNo = g.Key,
                    Packed = g.Sum(x => x.Pcs) ?? 0
                })
                .ToDictionary(x => x.OrderNo, x => x.Packed);

            var pending = rawDispatch
                            .GroupBy(x => new
                             {
                                 x.OrderNo,
                                 x.CustomerCode
                             })
                            .Select(g =>
                            {
                                var dispatchPcs = g.Sum(x => x.Pcs) ?? 0;

                                packedSummary.TryGetValue(
                                 g.Key.OrderNo,
                                 out int packedPcs);

                             return new
                            {
                                OrderNo = g.Key.OrderNo,
                                CustomerCode = g.Key.CustomerCode,
                                PendingPcs = dispatchPcs - packedPcs,
                                Mode = g.Max(x => x.ShipMode),
                                DispatchDate = g.Max(x => x.DispatchDate)
                            };
                    })
                        .Where(x => x.PendingPcs > 0)
                        .ToList<dynamic>();


            var packed = _dbcontext.TblPackings.GroupBy(x => new { x.CustomerCode, x.OrderNo })
                .Select(g => new
                {
                    Id = g.Max(x => x.Id),
                    CustomerCode = g.Key.CustomerCode,
                    OrderNo = g.Key.OrderNo,
                    Pcs = g.Sum(x => x.Pcs),
                    Mode = g.Max(x => x.Mode),
                    DespDate = g.Max(x => x.DespDate)
                })
                .OrderByDescending(x => x.OrderNo)
                .ToList<dynamic>();

            ViewBag.Pending = pending;
            ViewBag.Packed = packed;

            return View();
        }

        // ================= SAVE PACKING =================
        [HttpPost]
        public JsonResult SavePacking([FromBody] TblPacking model)
        {
            if (model == null || model.Pcs == null || model.Pcs <= 0)
                return Json(new { success = false, message = "Invalid PCS" });

            // ---- Get SrNos ----
            var srnos = _dbcontext.TblProductionAcks.Where(x => x.OrderNo == model.OrderNo).Select(x => x.Srno).ToList();

            // ---- Dispatch data ----
            var dispatchList = _dbcontext.TblCarpetDispatches.Where(x => srnos.Contains(x.SrNo) && x.Status == "DISPATCHED").ToList();

            if (!dispatchList.Any())
                return Json(new { success = false, message = "Dispatch not found" });

            var dispatchPcs = dispatchList.Sum(x => x.Pcs) ?? 0;

            // ---- Already packed ----
            var packedPcs = _dbcontext.TblPackings.Where(x => x.OrderNo == model.OrderNo).Sum(x => (int?)x.Pcs) ?? 0;

            if (packedPcs + model.Pcs > dispatchPcs)
                return Json(new
                {
                    success = false,
                    message = "Packing exceeds dispatch limit!"
                });

            // ---- Check existing packing row ----
            var existingPacking = _dbcontext.TblPackings.FirstOrDefault(x => x.OrderNo == model.OrderNo);

            if (existingPacking != null)
            {
                // UPDATE existing row
                existingPacking.Pcs=(existingPacking.Pcs ?? 0) + model.Pcs;

                existingPacking.UpdateBy =User.Identity?.Name ?? "System";

                existingPacking.UpdateByDate = DateTime.Now;
            }
            else
            {
                // INSERT new row
                model.Mode = dispatchList.First().ShipMode;
                model.EntryBy = User.Identity?.Name ?? "System";
                model.EntryByDate = DateTime.Now;
                model.Status = "PACKED";

                _dbcontext.TblPackings.Add(model);
            }

            _dbcontext.SaveChanges();

            return Json(new
            {
                success = true,
                message = "Packing saved successfully"
            });
        }

        // ================= OPEN EDIT =================
        public IActionResult EditPacking(int id)
        {
            var row = _dbcontext.TblPackings.FirstOrDefault(x => x.Id == id);

            if (row == null)
                return RedirectToAction("IndexPacking");

            return View(row);
        }

        // ================= SAVE EDIT =================
        [HttpPost]
        public IActionResult EditPacking(TblPacking model)
        {
            var row = _dbcontext.TblPackings.FirstOrDefault(x => x.Id == model.Id);

            if (row == null)
                return RedirectToAction("IndexPacking");

            var srnos = _dbcontext.TblProductionAcks.Where(x => x.OrderNo == model.OrderNo).Select(x => x.Srno).ToList();

            var dispatchPcs = _dbcontext.TblCarpetDispatches.Where(x => srnos.Contains(x.SrNo) && x.Status == "DISPATCHED").Sum(x => (int?)x.Pcs) ?? 0;

            var packedExceptCurrent = _dbcontext.TblPackings.Where(x => x.OrderNo == model.OrderNo && x.Id != model.Id).Sum(x => (int?)x.Pcs) ?? 0;

            if (model.Pcs == null || model.Pcs <= 0 || packedExceptCurrent + model.Pcs > dispatchPcs)
            {
                TempData["Error"] = $"PCS cannot exceed Dispatch PCS ({dispatchPcs})";
                return View(model);
            }

            row.Pcs = model.Pcs;
            row.DespDate = model.DespDate;
            row.UpdateBy = User.Identity?.Name ?? "System";
            row.UpdateByDate = DateTime.Now;

            _dbcontext.SaveChanges();

            TempData["Success"] = "Packing updated";
            return RedirectToAction("IndexPacking");
        }

        // ================= DELETE =================
        [HttpPost]
        public JsonResult DeletePackingOrder(int id)
        {
            var row = _dbcontext.TblPackings.FirstOrDefault(x => x.Id == id);

            if (row == null)
                return Json(new { success = false, message = "Record not found" });

            _dbcontext.TblPackings.Remove(row);
            _dbcontext.SaveChanges();

            return Json(new
            {
                success = true,
                message = "Packing deleted successfully"
            });
        }
        //============Print Page=========================
        public IActionResult PrintPendingPacking(string date)
        {
            ViewBag.PrintDate = date;

            var rawDispatch =
                (from m in _dbcontext.TblProductionAcks
                 join d in _dbcontext.TblCarpetDispatches
                     on m.Srno equals d.SrNo
                 where d.Status == "DISPATCHED"

                 select new
                 {
                     m.OrderNo,
                     d.CustomerCode,
                     d.ShipMode,
                     d.Pcs,
                     DispatchDate = d.DispatchDate
                 }).ToList();

            var pending = rawDispatch
                .GroupBy(x => new
                {
                    x.OrderNo,
                    x.CustomerCode,
                    x.ShipMode
                })
                .Select(g => new
                {
                    OrderNo = g.Key.OrderNo,
                    CustomerCode = g.Key.CustomerCode,
                    PendingPcs = g.Sum(x => x.Pcs) ?? 0,
                    Mode = g.Key.ShipMode,
                    DispatchDate = g.Max(x => x.DispatchDate)
                })
                .Where(x => x.PendingPcs > 0)
                .ToList();

            return View("PrintPendingPacking", pending);
        }

    }
}
