using Inspection_Outcome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Inspection_Outcome.Controllers
{
    public class OrderController : Controller
    {
        private readonly ErpDataContext _dbcontext;

        public OrderController(ErpDataContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public IActionResult IndexOrder()
        {
            string currentUser = User.Identity.Name;

            bool isAdmin = _dbcontext.TblUserMasters
                .Any(u => u.Username == currentUser
                          && u.Accounttype == "Admin");

            var query =
                from dr in _dbcontext.TblDesignReqDtls
                join drm in _dbcontext.TblDesignReqMsts
                    on dr.OrderId equals drm.Id
                join ord in _dbcontext.TblProductionAcks
                    on dr.SrNo equals ord.Srno
                join um in _dbcontext.TblUserMasters
                    on dr.Entryby equals um.Username
                where dr.SrNo.Contains("-PD-")
                      && ord.InvoiceNo == null
                select new
                {
                    drm.CustomerNo,
                    ProjectName = drm.ProjectName ?? drm.CustPono,
                    ord.OrderNo,
                    AreaName = dr.AreaCode ?? dr.DesignName,
                    CustEmailDt = drm.EntryDt,
                    Allocateddt = dr.Allocateddt,
                    Receiveddt = dr.Receiveddt,
                    CustSubmitdt = dr.CustSubmitdt,
                    CustApproveddt = dr.CustApproveddt,
                    SharedUser = um.Username
                };

            if (!isAdmin)
            {
                query = query.Where(x => x.SharedUser == currentUser);
            }

            var data = query
                .OrderByDescending(x => x.CustEmailDt)
                .ToList();

            ViewBag.Data = data;

            return View();
        }

        //public IActionResult IndexOrder()
        //{
        //    var data =
        //        (from dr in _dbcontext.TblDesignReqDtls
        //         join drm in _dbcontext.TblDesignReqMsts
        //              on dr.OrderId equals drm.Id
        //         join ord in _dbcontext.TblProductionAcks
        //             on dr.SrNo equals ord.Srno
        //         select new
        //         {
        //             dr,
        //             drm,
        //             ord
        //         })
        //         .AsEnumerable() // SQL se data fetch, aage C# me filter
        //         .Where(x => x.dr.SrNo.Contains("-PD-")
        //                     && x.ord.InvoiceNo == null)
        //         .OrderByDescending(x => x.dr.OrderId)
        //         .Select(x => new
        //         {
        //             x.drm.CustomerNo,
        //             ProjectName = x.drm.ProjectName ?? x.drm.CustPono,
        //             x.ord.OrderNo,
        //             AreaName = x.dr.AreaCode ?? x.dr.DesignName,
        //             x.dr.Allocateddt,
        //             x.dr.Receiveddt,
        //             x.dr.CustSubmitdt,
        //             x.dr.CustApproveddt
        //         })
        //         .ToList();

        //    ViewBag.Data = data;

        //    return View();
        //}


    }
}
