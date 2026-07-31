using Inspection_Outcome.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inspection_Outcome.Controllers
{
    public class DispatchedController : Controller
    {
        private readonly ErpDataContext _dbcontext;

        public DispatchedController(ErpDataContext dbcontext)
        {
            _dbcontext = dbcontext;

        }
        #region
        // ================= DISPATCH ENTRY PAGE =================
        [HttpGet]
        public IActionResult Dispatch()
        {
            ViewBag.Customers = _dbcontext.TblDesignReqMsts
                .Select(x => x.CustomerNo)
                .Distinct()
                .OrderBy(x => x)
                .ToList();
            return View();
        }

        [HttpGet]
        public IActionResult GetOrders(string customerCode)
        {
            if (string.IsNullOrEmpty(customerCode))
                return Json(new List<string>());

            var orders = (from a in _dbcontext.TblDesignReqMsts
                          join b in _dbcontext.TblDesignReqDtls on a.Id equals b.OrderId
                          join tbn in _dbcontext.TblProductionAcks on b.SrNo equals tbn.Srno
                          where a.CustomerNo == customerCode
                          select tbn.OrderNo ?? a.CustPono)
                         .Distinct()
                         .OrderBy(x => x)
                         .ToList();

            return Json(orders);
        }
        [HttpGet]
        public IActionResult GetPendingPartial(string customerCode, string orderNo)
        {
            var pending = GetPendingData(customerCode, orderNo);
            return PartialView("_PendingDispatch", pending);
        }

        [HttpGet]
        public IActionResult GetRejectedPartial(string customerCode, string orderNo)
        {
            var rejected = _dbcontext.TblCarpetDispatches
                .Where(x => x.CustomerCode == customerCode
                    && (string.IsNullOrEmpty(orderNo) || x.OrderNo == orderNo)
                    && x.Status == "REJECTED")
                .OrderByDescending(x => x.RejectDate)
                .ToList();
            return PartialView("_RejectedDispatch", rejected);
        }

        [HttpGet]
        public IActionResult GetDispatchedPartial(string customerCode, string orderNo)
        {
            var dispatched = _dbcontext.TblCarpetDispatches
                .Where(x => x.CustomerCode == customerCode
                    && (string.IsNullOrEmpty(orderNo) || x.OrderNo == orderNo)
                    && x.Status == "DISPATCHED")
                .OrderByDescending(x => x.DispatchDate)
                .ToList();
            return PartialView("_DispatchedDispatch", dispatched);
        }

        private List<TblCarpetDispatch> GetPendingData(string customerCode, string orderNo)
        {
            return (
                from mst in _dbcontext.TblDesignReqMsts
                join dtl in _dbcontext.TblDesignReqDtls on mst.Id equals dtl.OrderId
                join tbn in _dbcontext.TblProductionAcks on dtl.SrNo equals tbn.Srno
                where mst.CustomerNo == customerCode
                      && (string.IsNullOrEmpty(orderNo) || (tbn.OrderNo ?? mst.CustPono) == orderNo)
                let usedPcs = _dbcontext.TblCarpetDispatches
                    .Where(x => x.SrNo == dtl.SrNo &&
                               (x.Status == "PENDING" || x.Status == "REJECTED" || x.Status == "DISPATCHED"))
                    .Sum(x => x.Pcs ?? 0)
                where (dtl.Pcs ?? 0) > usedPcs
                select new TblCarpetDispatch
                {
                    CustomerCode = mst.CustomerNo,
                    ProjectName = mst.ProjectName,
                    OrderNo = tbn.OrderNo ?? mst.CustPono,
                    SrNo = dtl.SrNo,
                    DesignName = dtl.DesignName,
                    ColorName = dtl.Color,
                    Quality = dtl.Qlty,
                    Pcs = (dtl.Pcs ?? 0) - usedPcs,
                    WdthFt = dtl.WdthFt,
                    WdthInch = dtl.WdthInch,
                    LnthFt = dtl.LnthFt,
                    LnthInch = dtl.LnthInch
                }
            ).ToList();
        }
        [HttpGet]
        public IActionResult GetDispatchData(string customerCode, string orderNo)
        {
            if (string.IsNullOrEmpty(customerCode))
                return Json(new { pending = new List<object>(), rejected = new List<object>(), dispatched = new List<object>() });

            var pending = (
                from mst in _dbcontext.TblDesignReqMsts
                join dtl in _dbcontext.TblDesignReqDtls on mst.Id equals dtl.OrderId
                join tbn in _dbcontext.TblProductionAcks on dtl.SrNo equals tbn.Srno
                where mst.CustomerNo == customerCode
                      && (string.IsNullOrEmpty(orderNo) || (tbn.OrderNo ?? mst.CustPono) == orderNo)
                let usedPcs = _dbcontext.TblCarpetDispatches
                    .Where(x => x.SrNo == dtl.SrNo &&
                               (x.Status == "PENDING" || x.Status == "REJECTED" || x.Status == "DISPATCHED"))
                    .Sum(x => x.Pcs ?? 0)
                where (dtl.Pcs ?? 0) > usedPcs
                select new
                {
                    customerCode = mst.CustomerNo,
                    projectName = mst.ProjectName,
                    orderNo = tbn.OrderNo ?? mst.CustPono,
                    srNo = dtl.SrNo,
                    designName = dtl.DesignName,
                    colorName = dtl.Color,
                    quality = dtl.Qlty,
                    pcs = (dtl.Pcs ?? 0) - usedPcs,
                    wdthFt = dtl.WdthFt,
                    wdthInch = dtl.WdthInch,
                    lnthFt = dtl.LnthFt,
                    lnthInch = dtl.LnthInch
                }
            ).ToList();

            var rejected = _dbcontext.TblCarpetDispatches
                .Where(x => x.CustomerCode == customerCode
                    && (string.IsNullOrEmpty(orderNo) || x.OrderNo == orderNo)
                    && x.Status == "REJECTED")
                .OrderByDescending(x => x.RejectDate)
                .Select(x => new
                {
                    id = x.Id,
                    customerCode = x.CustomerCode,
                    orderNo = x.OrderNo,
                    srNo = x.SrNo,
                    designName = x.DesignName,
                    pcs = x.Pcs,
                    quality = x.Quality,
                    colorName = x.ColorName,
                    shipMode = x.ShipMode,
                    dispatchDate = x.DispatchDate != null ? x.DispatchDate.Value.ToString("dd/MM/yy") : "",
                    wdthFt = x.WdthFt,
                    wdthInch = x.WdthInch,
                    lnthFt = x.LnthFt,
                    lnthInch = x.LnthInch,
                    rejectRemark = x.RejectRemark
                }).ToList();

            var dispatched = _dbcontext.TblCarpetDispatches
                .Where(x => x.CustomerCode == customerCode
                    && (string.IsNullOrEmpty(orderNo) || x.OrderNo == orderNo)
                    && x.Status == "DISPATCHED")
                .OrderByDescending(x => x.DispatchDate)
                .Select(x => new
                {
                    id = x.Id,
                    customerCode = x.CustomerCode,
                    orderNo = x.OrderNo,
                    srNo = x.SrNo,
                    designName = x.DesignName,
                    pcs = x.Pcs,
                    quality = x.Quality,
                    colorName = x.ColorName,
                    shipMode = x.ShipMode,
                    dispatchDate = x.DispatchDate != null ? x.DispatchDate.Value.ToString("dd/MM/yy") : "",
                    wdthFt = x.WdthFt,
                    wdthInch = x.WdthInch,
                    lnthFt = x.LnthFt,
                    lnthInch = x.LnthInch
                }).ToList();

            return Json(new { pending, rejected, dispatched });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SendForApproval(string jsonData)
        {
            if (string.IsNullOrEmpty(jsonData))
                return Json(new { success = false, message = "No data received." });

            var settings = new Newtonsoft.Json.JsonSerializerSettings
            {
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore
            };

            var model = Newtonsoft.Json.JsonConvert.DeserializeObject<List<TblCarpetDispatch>>(jsonData, settings);

            if (model == null || !model.Any())
                return Json(new { success = false, message = "Model is empty." });

            if (!model.Any(x => x != null && x.IsSentForApproval))
                return Json(new { success = false, message = "Please select at least one row." });

            foreach (var item in model.Where(x => x != null && x.IsSentForApproval))
            {
                bool alreadyExists = _dbcontext.TblCarpetDispatches.Any(x =>
                    x.OrderNo == item.OrderNo &&
                    x.SrNo == item.SrNo &&
                    x.Status == "PENDING");

                if (alreadyExists) continue;

                _dbcontext.TblCarpetDispatches.Add(new TblCarpetDispatch
                {
                    CustomerCode = item.CustomerCode,
                    ProjectName = item.ProjectName,
                    OrderNo = item.OrderNo,
                    SrNo = item.SrNo,
                    DesignName = item.DesignName,
                    ColorName = item.ColorName,
                    Quality = item.Quality,
                    Pcs = item.Pcs,
                    ShipMode = item.ShipMode,
                    DispatchDate = item.ShipMode == "TBC" ? null : item.DispatchDate,
                    Remarks = item.Remarks,
                    WdthFt = item.WdthFt,
                    WdthInch = item.WdthInch,
                    LnthFt = item.LnthFt,
                    LnthInch = item.LnthInch,
                    Status = "PENDING",
                    CreatedBy = "User",
                    CreatedOn = DateTime.Now
                });
            }

            _dbcontext.SaveChanges();
            return Json(new { success = true, message = "Sent for approval successfully." });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateDispatched(string jsonData)
        {
            if (string.IsNullOrEmpty(jsonData))
                return Json(new { success = false, message = "jsonData is null or empty." });

            try
            {
                var rows = Newtonsoft.Json.JsonConvert.DeserializeObject<List<UpdateDispatchRow>>(jsonData);

                if (rows == null || !rows.Any())
                    return Json(new { success = false, message = "No rows found after deserialize." });

                foreach (var item in rows)
                {
                    var existing = _dbcontext.TblCarpetDispatches.FirstOrDefault(x => x.Id == item.Id);
                    if (existing == null) continue;

                    existing.ShipMode = item.ShipMode;
                    existing.DispatchDate = string.IsNullOrEmpty(item.DispatchDate)
                                            ? null
                                            : DateTime.Parse(item.DispatchDate);
                    existing.UpdatedOn = DateTime.Now;
                }

                _dbcontext.SaveChanges();
                return Json(new { success = true, message = "Updated successfully." });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        public class UpdateDispatchRow
        {
            public int Id { get; set; }
            public string ShipMode { get; set; }
            public string DispatchDate { get; set; }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteRejected([FromBody] DeleteRequest req)
        {
            var record = _dbcontext.TblCarpetDispatches.Find(req.Id);
            if (record == null)
                return Json(new { success = false, message = "Record not found." });

            _dbcontext.TblCarpetDispatches.Remove(record);
            _dbcontext.SaveChanges();
            return Json(new { success = true, message = "Deleted successfully." });
        }

        public class DeleteRequest { public int Id { get; set; } }

        // ================= APPROVAL PAGE =================
        public IActionResult Approval()
        {
            var list = _dbcontext.TblCarpetDispatches
                .Where(x => x.Status == "PENDING")
                .GroupBy(x => new { x.CustomerCode, x.OrderNo, x.ShipMode, x.DispatchDate })
                .Select(g => new TblCarpetDispatch
                {
                    CustomerCode = g.Key.CustomerCode,
                    OrderNo = g.Key.OrderNo,
                    ShipMode = g.Key.ShipMode,
                    DispatchDate = g.Key.DispatchDate,
                    Pcs = g.Sum(x => x.Pcs),
                    CreatedOn = g.Max(x => x.CreatedOn),
                    Id = g.First().Id
                })
                .OrderByDescending(x => x.CreatedOn)
                .ToList();

            return View(list);
        }

        // ================= APPROVE BULK (AJAX) =================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ApproveBulk([FromBody] List<ApproveRow> rows)
        {
            if (rows == null || rows.Count == 0)
                return Json(new { success = false, message = "No rows selected." });

            foreach (var selected in rows)
            {
                DateTime? parsedDate = null;
                if (!string.IsNullOrEmpty(selected.DispatchDate))
                    parsedDate = DateTime.Parse(selected.DispatchDate);

                var dbRows = _dbcontext.TblCarpetDispatches
                    .Where(x => x.OrderNo == selected.OrderNo
                             && x.ShipMode == selected.ShipMode
                             && x.Status == "PENDING"
                             && (parsedDate == null
                                    ? x.DispatchDate == null
                                    : x.DispatchDate == parsedDate))
                    .ToList();

                foreach (var d in dbRows)
                {
                    d.Status = "DISPATCHED";
                    d.ApprovedBy = "DesignHead";
                    d.ApprovedOn = DateTime.Now;
                }
            }

            _dbcontext.SaveChanges();
            return Json(new { success = true, message = "Approved successfully." });
        }

        public class ApproveRow
        {
            public string OrderNo { get; set; }
            public string ShipMode { get; set; }
            public string DispatchDate { get; set; }
        }

        // ================= REJECT BULK (AJAX) =================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RejectBulk([FromBody] RejectBulkRequest req)
        {
            if (req?.Orders == null || req.Orders.Count == 0)
                return Json(new { success = false, message = "No rows selected." });

            var rows = _dbcontext.TblCarpetDispatches
                .Where(x => req.Orders.Contains(x.OrderNo) && x.Status == "PENDING")
                .ToList();

            foreach (var d in rows)
            {
                d.Status = "REJECTED";
                d.RejectRemark = req.Remark;
                d.RejectDate = DateTime.Now;
            }

            _dbcontext.SaveChanges();
            return Json(new { success = true, message = "Rejected successfully." });
        }

        public class RejectBulkRequest
        {
            public List<string> Orders { get; set; }
            public string Remark { get; set; }
        }
        #endregion

        // ================= DELETE REJECTED (AJAX) =================
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult DeleteRejected([FromBody] DeleteRequest req)
        //{
        //    var d = _dbcontext.TblCarpetDispatches
        //        .FirstOrDefault(x => x.Id == req.Id && x.Status == "REJECTED");

        //    if (d == null)
        //        return Json(new { success = false, message = "Record not found." });

        //    _dbcontext.TblCarpetDispatches.Remove(d);
        //    _dbcontext.SaveChanges();
        //    return Json(new { success = true, message = "Deleted successfully." });
        //}

        // ================= UPDATE DISPATCHED (AJAX) =================
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult UpdateDispatched([FromBody] List<TblCarpetDispatch> rows)
        //{
        //    if (rows == null || rows.Count == 0)
        //        return Json(new { success = false, message = "No rows selected." });

        //    foreach (var item in rows)
        //    {
        //        var existing = _dbcontext.TblCarpetDispatches.FirstOrDefault(x => x.Id == item.Id);
        //        if (existing != null)
        //        {
        //            existing.ShipMode = item.ShipMode;
        //            existing.DispatchDate = item.DispatchDate;
        //        }
        //    }

        //    _dbcontext.SaveChanges();
        //    return Json(new { success = true, message = "Updated successfully." });
        //}

    }
}
