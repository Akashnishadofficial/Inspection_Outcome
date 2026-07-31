using Inspection_Outcome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Inspection_Outcome.Controllers
{
    public class BuyerdesignerController : Controller
    {
        private readonly ErpDataContext _dbcontext;

        public BuyerdesignerController(ErpDataContext dbcontext)
        {
            _dbcontext = dbcontext;
            _dbcontext.Database.SetCommandTimeout(180);
        }
        public IActionResult Index()
        {
            return View();
        }
        //Buyerdesigncolor code
        [HttpGet]
        public IActionResult BuyerdesignColor()
        {
            ViewBag.Clients = _dbcontext.TblClients
                                .Select(x => new
                                {
                                    ClientCode = x.ClientCode,
                                    ClientName = x.ClientName
                                })
                                .OrderBy(x => x.ClientName)
                                .ToList();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BuyerdesignColor(Tblbuyerdesigncolor bd)
        {
            //  ALWAYS reload clients
            ViewBag.Clients = _dbcontext.TblClients
                                .Select(x => new
                                {
                                    x.ClientCode,
                                    x.ClientName
                                })
                                .OrderBy(x => x.ClientName)
                                .ToList();

            if (!ModelState.IsValid)
            {
                ViewBag.Message = "Invalid Data";
                return View(bd);
            }
            try
            {
                bd.EntryBy = "USER";
                bd.EntryDate = DateTime.Now;

               await _dbcontext.Tblbuyerdesigncolors.AddAsync(bd);
               await _dbcontext.SaveChangesAsync();

                ViewBag.Message = "Record Added Successfully!";
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Sorry! Record Not Added due to technical issue. " + ex.Message;
            }
            return View();
        }
        public IActionResult ShowBuyerdesign()
        {
            ViewBag.Clients = _dbcontext.TblClients
                                .Select(x => new
                                {
                                    x.ClientCode,
                                    x.ClientName
                                })
                                .OrderBy(x => x.ClientName)
                                .ToList();
            return View();
        }
        public JsonResult GetLatestBuyerDesigns()
        {
            var data = _dbcontext.Tblbuyerdesigncolors
                        .OrderByDescending(x => x.Id)   // latest first
                        .Take(20)                       // only 20 records
                        .Select(x => new
                        {
                            id = x.Id,
                            buyercode = x.Buyercode ?? "",
                            designNo = x.Designno ?? "",
                            quality = x.Quality ?? "",
                            colour = x.Colour ?? "",
                            collection = x.Collection ?? "",
                            pdesign = x.Pdesign ?? "",
                            latex = x.Latex,
                            berai = x.Berai,
                            streching = x.Streching,
                            pattiMori = x.PattiMori,
                            clipping = x.Clipping,
                            washing = x.Washing,
                            iiibacking = x.Iiibacking,
                            embossing = x.Embossing,
                            binding = x.Binding,
                            newar = x.Newar
                        })
                        .ToList();

            return Json(data);
        }

        // Table Data
        public JsonResult GetBuyerDetails(string buyercode)
        {
            var data = _dbcontext.Tblbuyerdesigncolors
                .Where(x => x.Buyercode.Contains(buyercode))
                .OrderByDescending(x => x.Id)
                .Select(x => new
                {
                    id = x.Id,
                    buyercode = x.Buyercode ?? "",
                    designNo = x.Designno ?? "",
                    quality = x.Quality ?? "",
                    colour = x.Colour ?? "",
                    collection = x.Collection ?? "",
                    pdesign = x.Pdesign ?? "",
                    latex = x.Latex,
                    berai = x.Berai,
                    streching = x.Streching,
                    pattiMori = x.PattiMori,
                    clipping = x.Clipping,
                    washing = x.Washing,
                    iiibacking = x.Iiibacking,
                    embossing = x.Embossing,
                    binding = x.Binding,
                    newar = x.Newar
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
            var data = _dbcontext.Tblbuyerdesigncolors.FirstOrDefault(x => x.Id == model.Id);
            if (data == null)
                return NotFound();

            // TEXT FIELDS
            data.Designno = model.Designno;
            data.Quality = model.Quality;
            data.Colour = model.Colour;
            data.Collection = model.Collection;
            data.Pdesign = model.Pdesign;

            // PROCESS FLAGS (VERY IMPORTANT)
            data.Latex = model.Latex;
            data.Berai = model.Berai;
            data.Streching = model.Streching;
            data.PattiMori = model.PattiMori;
            data.Clipping = model.Clipping;
            data.Washing = model.Washing;
            data.Iiibacking = model.Iiibacking;
            data.Embossing = model.Embossing;
            data.Binding = model.Binding;
            data.Newar = model.Newar;

            // AUDIT
            data.EntryBy = "USER";
            data.EntryDate = DateTime.Now;

            _dbcontext.SaveChanges();

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
