using Inspection_Outcome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Inspection_Outcome.Controllers
{
    public class HomeController : Controller
    {
        private readonly ErpDataContext _dbcontext;

        public HomeController(ErpDataContext dbcontext)
        {
            _dbcontext = dbcontext;
            _dbcontext.Database.SetCommandTimeout(180);
        }

        public IActionResult Inspection()
        {
            return View();
        }

        // ================= INSPECTION =====================

        // Get Customers
        [HttpGet]
        public JsonResult GetCustomers()
        {
            var customers = _dbcontext.TblDesignReqMsts
                .AsNoTracking()
                .Where(x => !string.IsNullOrEmpty(x.CustomerNo)) // <-- filter null / empty
                .Select(x => x.CustomerNo)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            return Json(customers);
        }


        [HttpGet]
        public JsonResult GetProjects(string custCode)
        {
            var projects = _dbcontext.TblDesignReqMsts
                .AsNoTracking()
                .Where(x => x.CustomerNo == custCode && !string.IsNullOrEmpty(x.ProjectName))
                .Select(x => x.ProjectName)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            return Json(projects);
        }


        [HttpGet]
        public JsonResult GetInspectionData(string custCode, string projectName)
        {
            var data = (from d in _dbcontext.TblDesignReqMsts
                        join m in _dbcontext.TblDesignReqDtls
                        on d.Id equals m.OrderId
                        where d.CustomerNo == custCode && d.ProjectName == projectName
                        select new
                        {
                            id = m.Id,
                            customerCode = d.CustomerNo ?? "",
                            projectName = d.ProjectName ?? "",
                            serialNo = m.SrNo ?? "",
                            quality = m.Qlty ?? "",
                            design = m.DesignName ?? "",
                            color = m.Color ?? "",
                            Uom = m.Uom ?? "",
                            Pcs = m.Pcs ?? 0,
                            width_ft = m.WdthFt ?? 0,
                            width_inch = m.WdthInch ?? 0,
                            lnth_ft = m.LnthFt ?? 0,
                            lnth_inch = m.LnthInch ?? 0
                        }).ToList();

            return Json(data);
        }
        [HttpGet]
        public JsonResult GetInspectionDashboardData(string type, string custCode, string projectName)
        {
            // ================= PASS / REJECT =================
            if (type == "PASS" || type == "REJECT")
            {
                var data = _dbcontext.TblCarpetInspections
                    .Where(x => x.CustomerCode == custCode
                             && x.ProjectName == projectName
                             && x.Status == type)
                    .Select(x => new
                    {
                        x.Id,
                        customerCode = x.CustomerCode,
                        projectName = x.ProjectName,
                        srNo = x.SrNo,
                        quality = x.Quality,
                        designName = x.DesignName,
                        colorName = x.ColorName,
                        uom = x.Uom,
                        pcs = x.Pcs??0,
                        wdthFt = x.WdthFt,
                        wdthInch = x.WdthInch,
                        lnthFt = x.LnthFt,
                        lnthInch = x.LnthInch,
                        status = x.Status,
                        createdOn = x.CreatedOn
                    })
                    .OrderByDescending(x => x.createdOn)
                    .ToList();

                return Json(data);
            }

            // ================= PENDING =================
            // Pending = jo DesignReqDtl me hai BUT TblCarpetInspection me nahi hai

            var pending = (
                from d in _dbcontext.TblDesignReqMsts
                join m in _dbcontext.TblDesignReqDtls
                    on d.Id equals m.OrderId
                where d.CustomerNo == custCode
                   && d.ProjectName == projectName
                   && !_dbcontext.TblCarpetInspections.Any(ci =>
                        ci.SrNo == m.SrNo &&
                        ci.ProjectName == d.ProjectName)
                select new
                {
                    id = m.Id,
                    customerCode = d.CustomerNo,
                    projectName = d.ProjectName,
                    srNo = m.SrNo,
                    quality = m.Qlty,
                    designName = m.DesignName,
                    colorName = m.Color,
                    uom = m.Uom,
                    pcs = m.Pcs??0,
                    wdthFt = m.WdthFt,
                    wdthInch = m.WdthInch,
                    lnthFt = m.LnthFt,
                    lnthInch = m.LnthInch,
                    status = "PENDING",
                    createdOn = d.EntryDt
                }
            ).ToList();

            return Json(pending);
        }
        [HttpPost]
        public JsonResult SaveInspectionResult([FromBody] Dictionary<string, object> data)
        {
            var ids = ((System.Text.Json.JsonElement)data["ids"])
                        .EnumerateArray().Select(x => x.GetInt32()).ToList();

            var result = data["result"].ToString();

            var rows = (from d in _dbcontext.TblDesignReqMsts
                        join m in _dbcontext.TblDesignReqDtls
                        on d.Id equals m.OrderId
                        where ids.Contains(m.Id)
                        select new { d, m }).ToList();

            foreach (var x in rows)
            {
                bool already = _dbcontext.TblCarpetInspections
                    .Any(z => z.SrNo == x.m.SrNo && z.ProjectName == x.d.ProjectName);

                if (already) continue;

                TblCarpetInspection obj = new TblCarpetInspection();

                obj.CustomerCode = x.d.CustomerNo;
                obj.ProjectName = x.d.ProjectName;
                obj.SrNo = x.m.SrNo;
                obj.Quality = x.m.Qlty;
                obj.DesignName = x.m.DesignName;
                obj.ColorName = x.m.Color;
                obj.Uom = x.m.Uom;
                obj.Pcs = x.m.Pcs??0;
                obj.WdthFt = x.m.WdthFt;
                obj.WdthInch = x.m.WdthInch;
                obj.LnthFt = x.m.LnthFt;
                obj.LnthInch = x.m.LnthInch;
                obj.Status = result;
                obj.CreatedOn = DateTime.Now;
                obj.CreatedBy = "Admin";

                if (result == "PASS")
                    obj.PassDt = DateTime.Now;
                else
                    obj.RejectDt = DateTime.Now;

                _dbcontext.TblCarpetInspections.Add(obj);
            }

            _dbcontext.SaveChanges();

            return Json(new { success = true, message = "Inspection saved successfully!" });
        }
        [HttpPost]
        public JsonResult DeleteInspection(int id)
        {
            var row = _dbcontext.TblCarpetInspections.FirstOrDefault(x => x.Id == id);

            if (row == null)
            {
                return Json(new { success = false, message = "Record not found" });
            }

            _dbcontext.TblCarpetInspections.Remove(row);
            _dbcontext.SaveChanges();

            return Json(new { success = true, message = "Record deleted and moved to Pending!" });
        }


        // ================= DISPATCH =====================
        

        public IActionResult Dispatch()
        {
            return View();
        }

        // Customers
        public JsonResult GetDispatchCustomers()
        {
            var data = _dbcontext.TblCarpetInspections
                .Where(x => x.Status == "PASS" || x.Status == "DISPATCH")
                .Select(x => x.CustomerCode)
                .Distinct()
                .ToList();

            return Json(data);
        }

        // Projects
        public JsonResult GetDispatchProjects(string customerCode)
        {
            var data = _dbcontext.TblCarpetInspections
                .Where(x => x.CustomerCode == customerCode)
                .Select(x => x.ProjectName)
                .Distinct()
                .ToList();

            return Json(data);
        }

        // ================= DASHBOARD =====================

        public JsonResult GetDispatchDashboardData(string type, string custCode, string projectName)
        {
            if (type == "PENDING")
            {
                var pending = _dbcontext.TblCarpetInspections
                    .Where(x => x.CustomerCode == custCode
                             && x.ProjectName == projectName
                             && x.Status == "PASS")
                    .Select(x => new
                    {
                        x.Id,
                        x.CustomerCode,
                        x.ProjectName,
                        x.SrNo,
                        x.Quality,
                        x.DesignName,
                        x.ColorName,
                        x.Uom,
                        x.Pcs,
                        x.WdthFt,
                        x.WdthInch,
                        x.LnthFt,
                        x.LnthInch
                    })
                    .OrderBy(x => x.SrNo)
                    .ToList();

                return Json(new { list = pending });
            }
            else
            {
                var dispatched = _dbcontext.TblCarpetDispatches
                    .Where(x => x.CustomerCode == custCode
                             && x.ProjectName == projectName)
                    .Select(x => new
                    {
                        x.Id,
                        x.CustomerCode,
                        x.ProjectName,
                        x.SrNo,
                        x.Quality,
                        x.DesignName,
                        x.ColorName,
                        x.Uom,
                        x.Pcs,
                        x.WdthFt,
                        x.WdthInch,
                        x.LnthFt,
                        x.LnthInch,
                        x.ShipMode,
                        x.DispatchDate
                    })
                    .OrderByDescending(x => x.DispatchDate)
                    .ToList();

                return Json(new { list = dispatched });
            }
        }

        // ================= SAVE DISPATCH =====================

        [HttpPost]
        public JsonResult SaveDispatch([FromBody] List<TblCarpetDispatch> model)
        {
            if (model == null || model.Count == 0)
                return Json(new { success= false, message = "No data received" });

            try
            {
                foreach (var item in model)
                {
                    if (string.IsNullOrWhiteSpace(item.SrNo))
                        continue;

                    var srno = item.SrNo.Trim();

                    var insp = _dbcontext.TblCarpetInspections
                                .FirstOrDefault(x => x.SrNo == srno && x.Status == "PASS");

                    if (insp == null)
                        continue;

                    bool already = _dbcontext.TblCarpetDispatches.Any(x =>
                        x.SrNo == srno &&
                        x.ProjectName == insp.ProjectName &&
                        x.CustomerCode == insp.CustomerCode);

                    if (already)
                        continue;

                    var dispatch = new TblCarpetDispatch
                    {
                        CustomerCode = insp.CustomerCode,
                        ProjectName = insp.ProjectName,
                        SrNo = srno,

                        Quality = insp.Quality,
                        DesignName = insp.DesignName,
                        ColorName = insp.ColorName,
                        Uom = insp.Uom,

                        Pcs = insp.Pcs,
                        WdthFt = insp.WdthFt,
                        WdthInch = insp.WdthInch,
                        LnthFt = insp.LnthFt,
                        LnthInch = insp.LnthInch,

                        ShipMode = item.ShipMode,
                        DispatchDate = item.DispatchDate ?? DateTime.Now,

                        Status = "DISPATCH",
                        CreatedOn = DateTime.Now,
                        CreatedBy = "Admin"
                    };

                    _dbcontext.TblCarpetDispatches.Add(dispatch);

                    insp.Status = "DISPATCH";
                    insp.DispatchDate = dispatch.DispatchDate;
                    insp.UpdatedOn = DateTime.Now;
                    insp.UpdatedBy = "Admin";
                }

                _dbcontext.SaveChanges();

                return Json(new { success = true, message = "Dispatch Saved Successfully" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        // ================= DELETE DISPATCH =====================

        [HttpPost]
        public JsonResult DeleteDispatch(int id)
        {
            try
            {
                var dispatch = _dbcontext.TblCarpetDispatches.FirstOrDefault(x => x.Id == id);

                if (dispatch == null)
                    return Json(new { success = false, message = "Record not found" });

                var insp = _dbcontext.TblCarpetInspections.FirstOrDefault(x => x.SrNo == dispatch.SrNo && x.ProjectName == dispatch.ProjectName && x.CustomerCode == dispatch.CustomerCode);

                if (insp != null)
                {
                    insp.Status = "PASS";
                    insp.DispatchDate = null;
                    insp.UpdatedOn = DateTime.Now;
                    insp.UpdatedBy = "Admin";
                }

                _dbcontext.TblCarpetDispatches.Remove(dispatch);

                _dbcontext.SaveChanges();

                return Json(new { success = true, message = "Moved back to Pending" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        //Buyerdesigncolor code
        public IActionResult BuyerdesignColor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BuyerdesignColor(Tblbuyerdesigncolor bd)
        {
            string msg = "";
            try
            {
                bd.EntryBy = "USER";              
                bd.EntryDate = DateTime.Now;     
                _dbcontext.Tblbuyerdesigncolors.Add(bd);
                _dbcontext.SaveChanges();
                msg = "Record Add Successfully!";
            }
            catch (Exception ex)
            {
                msg ="Sorry! due to some technical issue"+ ex.Message;
                msg = "Sorry! Record Not Added";
            }
            ViewBag.Message = msg;
            return View();
        }
        public IActionResult ShowBuyerdesign()
        {
            ViewBag.BuyerNumbers = _dbcontext.Tblbuyerdesigncolors
                                .Select(x => x.Bno)
                                .Distinct()
                                .ToList();
            return View();
        }

        // BuyerCode by BuyerNumber
        public JsonResult GetBuyerCodes(string bno)
        {
            var codes = _dbcontext.Tblbuyerdesigncolors
                        .Where(x => x.Bno == bno)
                        .Select(x => x.Buyercode)
                        .Distinct()
                        .ToList();

            return Json(codes);
        }

        // Table Data
        public JsonResult GetBuyerDetails(string bno, string buyercode)
        {
            var data = _dbcontext.Tblbuyerdesigncolors
                        .Where(x => x.Bno == bno && x.Buyercode == buyercode)
                        .OrderByDescending(x => x.Id)
                        .Select(x => new
                        {
                            id = x.Id,
                            bno =x.Bno??"",
                            buyercode=x.Buyercode??"",
                            designNo = x.Designno ?? "",
                            quality = x.Quality ?? "",
                            colour = x.Colour ?? "",
                            collection=x.Collection ?? "",
                            pdesign=x.Pdesign ?? ""
                            
                        }).ToList();

            return Json(data);
        }
        public IActionResult EditBuyerDesign(int id)
        {
            var data = _dbcontext.Tblbuyerdesigncolors.FirstOrDefault(x => x.Id == id);
            if (data == null)
                return NotFound();

            return View(data);
        }
        [HttpPost]
        public IActionResult EditBuyerDesign(Tblbuyerdesigncolor model)
        {
            var data = _dbcontext.Tblbuyerdesigncolors
                                 .FirstOrDefault(x => x.Id == model.Id);

            if (data == null)
            {
                return NotFound(); // record hi nahi mila
            }

            // fields update
            data.Designno = model.Designno;
            data.Quality = model.Quality;
            data.Colour = model.Colour;
            data.Collection = model.Collection;
            data.Pdesign = model.Pdesign;

            // audit fields
            data.EntryBy = "USER";
            data.EntryDate = DateTime.Now;

            _dbcontext.SaveChanges(); //
            TempData["UpdateSuccess"] = "Record updated successfully!";

            return RedirectToAction("ShowBuyerdesign");
        }


        [HttpPost]
        public JsonResult DeleteBuyerDesign(int id)
        {
            var data = _dbcontext.Tblbuyerdesigncolors.Find(id);

            if (data == null)
                return Json(new { success = false, message = "Record not found" });

            _dbcontext.Tblbuyerdesigncolors.Remove(data);
            _dbcontext.SaveChanges();

            return Json(new { success = true, message = "Record deleted successfully" });
        }



    }
}
