using Inspection_Outcome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class DispatchController : Controller
{
    private readonly ErpDataContext _db;

    public DispatchController(ErpDataContext db)
    {
        _db = db;
    }

    // ================= PAGE =================
    public IActionResult Dispatch()
    {
        return View();
    }

    // ================= CUSTOMER =================
    public JsonResult GetCustomers()
    {
        var list =
        (
            from mst in _db.TblDesignReqMsts
            join dtl in _db.TblDesignReqDtls on mst.Id equals dtl.OrderId
            select mst.CustomerNo
        )
        .Distinct()
        .OrderBy(x => x)
        .ToList();

        return Json(list);
    }

    // ================= PROJECT =================
    public JsonResult GetProjects(string customerCode)
    {
        var list = _db.TblDesignReqMsts
            .Where(x => x.CustomerNo == customerCode)
            .Select(x => x.ProjectName)
            .Distinct()
            .OrderBy(x => x)
            .ToList();

        return Json(list);
    }

    // ================= PENDING TAB =================
    public JsonResult GetPendingData(string customerCode, string projectName)
    {
        var data =
        (
            from d in _db.TblDesignReqMsts
            join m in _db.TblDesignReqDtls
                on d.Id equals m.OrderId
            where d.CustomerNo == customerCode
               && d.ProjectName == projectName
               && !_db.TblCarpetDispatches.Any(x =>
                      x.SrNo == m.SrNo   // 🔥 BLOCK ALL STATUSES
                  )
            select new
            {
                id = m.Id,
                customerCode = d.CustomerNo ?? "",
                projectName = d.ProjectName ?? "",
                srNo = m.SrNo ?? "",
                designName = m.DesignName ?? "",
                colorName = m.Color ?? "",
                quality = m.Qlty ?? "",
                pcs = m.Pcs ?? 0,
                shipMode = "",
                dispatchDate = (DateTime?)null,
                wdthFt = m.WdthFt ?? 0,
                wdthInch = m.WdthInch ?? 0,
                lnthFt = m.LnthFt ?? 0,
                lnthInch = m.LnthInch ?? 0
            }
        ).ToList();

        return Json(data);
    }

    // ================= DISPATCH TAB =================
    public JsonResult GetDispatchData(string customerCode, string projectName)
    {
        var list = _db.TblCarpetDispatches
            .Where(x => x.CustomerCode == customerCode
                     && x.ProjectName == projectName
                     && x.Status == "DISPATCHED")
            .Select(x => new TblCarpetDispatch
            {
                CustomerCode = x.CustomerCode,
                ProjectName = x.ProjectName,
                SrNo = x.SrNo,
                DesignName = x.DesignName,
                ColorName = x.ColorName,
                Quality = x.Quality,
                Pcs = x.Pcs,
                ShipMode = x.ShipMode,
                DispatchDate = x.DispatchDate,
                WdthFt = x.WdthFt,
                WdthInch = x.WdthInch,
                LnthFt = x.LnthFt,
                LnthInch = x.LnthInch
            })
            .ToList();

        return Json(list);
    }

    // ================= SEND FOR APPROVAL =================
    [HttpPost]
    public JsonResult SendForApproval([FromBody] List<TblCarpetDispatch> model)
    {
        foreach (var item in model)
        {
            var exist = _db.TblCarpetDispatches
                .FirstOrDefault(x => x.SrNo == item.SrNo && x.Status == "PENDING");

            DateTime? safeDate =
                item.DispatchDate == DateTime.MinValue
                ? null
                : item.DispatchDate;

            if (exist == null)
            {
                TblCarpetDispatch d = new TblCarpetDispatch
                {
                    CustomerCode = item.CustomerCode,
                    ProjectName = item.ProjectName,
                    SrNo = item.SrNo,
                    DesignName = item.DesignName,
                    ColorName = item.ColorName,
                    Quality = item.Quality,
                    Pcs = item.Pcs,
                    ShipMode = item.ShipMode,
                    DispatchDate = safeDate,

                    // 🔥 WIDTH / LENGTH SAVE HERE
                    WdthFt = item.WdthFt,
                    WdthInch = item.WdthInch,
                    LnthFt = item.LnthFt,
                    LnthInch = item.LnthInch,

                    Status = "PENDING",
                    CreatedBy = "User",
                    CreatedOn = DateTime.Now
                };


                _db.TblCarpetDispatches.Add(d);
            }
            else
            {
                exist.Pcs = item.Pcs;
                exist.ShipMode = item.ShipMode;
                exist.DispatchDate = safeDate;

                exist.Quality = item.Quality;
                exist.WdthFt = item.WdthFt;
                exist.WdthInch = item.WdthInch;
                exist.LnthFt = item.LnthFt;
                exist.LnthInch = item.LnthInch;

            }
        }

        _db.SaveChanges();
        return Json(new { success = true, message = "Sent for Approval" });
    }

    // ================= APPROVAL PAGE =================
    public IActionResult Approval()
    {
        var list = _db.TblCarpetDispatches
            .Where(x => x.Status == "PENDING")
            .OrderBy(x => x.CreatedOn)
            .ToList();

        return View(list);
    }

    // ================= APPROVE =================
    [HttpPost]
    public JsonResult Approve(int id, int pcs, string shipMode, DateTime date)
    {
        var d = _db.TblCarpetDispatches.First(x => x.Id == id);

        d.Pcs = pcs;
        d.ShipMode = shipMode;
        d.DispatchDate = date;
        d.Status = "DISPATCHED";
        d.ApprovedBy = "DesignHead";
        d.ApprovedOn = DateTime.Now;

        _db.SaveChanges();
        return Json(true);
    }


    // ================= REJECT =================
    [HttpPost]
    public JsonResult Reject(int id, string remark)
    {
        var d = _db.TblCarpetDispatches.First(x => x.Id == id);
        d.Status = "REJECTED";
        d.RejectRemark = remark;   // ✅ already saved
        _db.SaveChanges();
        return Json(true);
    }

    public JsonResult GetRejectedData(string customerCode, string projectName)
    {
        var list = _db.TblCarpetDispatches
            .Where(x => x.CustomerCode == customerCode
                     && x.ProjectName == projectName
                     && x.Status == "REJECTED")
            .Select(x => new TblCarpetDispatch
            {
                Id = x.Id,
                CustomerCode = x.CustomerCode,
                ProjectName = x.ProjectName,
                SrNo = x.SrNo,
                DesignName = x.DesignName,
                ColorName = x.ColorName,
                Quality = x.Quality,
                Pcs = x.Pcs,
                ShipMode = x.ShipMode,
                DispatchDate = x.DispatchDate,
                RejectRemark = x.RejectRemark,
                WdthFt = x.WdthFt,
                WdthInch = x.WdthInch,
                LnthFt = x.LnthFt,
                LnthInch = x.LnthInch
            })
            .ToList();

        return Json(list);
    }
    [HttpPost]
    public JsonResult ResendForApproval([FromBody] List<TblCarpetDispatch> model)
    {
        foreach (var item in model)
        {
            var d = _db.TblCarpetDispatches.First(x => x.Id == item.Id);

            d.Pcs = item.Pcs;
            d.ShipMode = item.ShipMode;
            d.DispatchDate = item.DispatchDate;

            d.Status = "PENDING";     // 🔥 BACK TO APPROVAL
            d.RejectRemark = null;
            d.UpdatedOn = DateTime.Now;
            d.UpdatedBy = "User";
        }

        _db.SaveChanges();
        return Json(new { success = true, message = "Resent for Approval" });
    }
    public JsonResult GetTabCounts(string customerCode, string projectName)
    {
        var pending = _db.TblDesignReqDtls.Count(x =>
    _db.TblDesignReqMsts.Any(m =>
        m.Id == x.OrderId &&
        m.CustomerNo == customerCode &&
        m.ProjectName == projectName
    ) &&
    !_db.TblCarpetDispatches.Any(d =>
        d.SrNo == x.SrNo   // 🔥 SAME RULE AS GetPendingData
    )
);


        var rejected = _db.TblCarpetDispatches.Count(x =>
            x.CustomerCode == customerCode &&
            x.ProjectName == projectName &&
            x.Status == "REJECTED"
        );

        var dispatched = _db.TblCarpetDispatches.Count(x =>
            x.CustomerCode == customerCode &&
            x.ProjectName == projectName &&
            x.Status == "DISPATCHED"
        );

        return Json(new { pending, rejected, dispatched });
    }
    [HttpPost]
    public IActionResult DeleteRejected(int id)
    {
        var d = _db.TblCarpetDispatches.First(x => x.Id == id);
        _db.TblCarpetDispatches.Remove(d);
        _db.SaveChanges();
        return Json(true);
    }



}
