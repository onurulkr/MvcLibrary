using MvcLibrary.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcLibrary.Controllers
{
    public class LoanedController : Controller
    {
        // GET: Loaned
        DbLibraryEntities db = new DbLibraryEntities();

        public ActionResult Index()
        {
            var values = db.tblMovements.ToList();

            return View(values);
        }

        [HttpGet]
        public ActionResult GiveLoaned()
        {
            //List<SelectListItem> value1 = (from i in db.tblMembers.ToList()
            //                               select new SelectListItem
            //                               {
            //                                   Text = i.MemberName + ' ' + i.MemberSurname,
            //                                   Value = i.MemberId.ToString()
            //                               }).ToList();
            //ViewBag.vl1 = value1;

            //List<SelectListItem> value2 = (from i in db.tblBooks.ToList()
            //                               select new SelectListItem
            //                               {
            //                                   Text = i.BookName,
            //                                   Value = i.BookId.ToString()
            //                               }).ToList();
            //ViewBag.vl2 = value2;

            //List<SelectListItem> value3 = (from i in db.tblWorkers.ToList()
            //                               select new SelectListItem
            //                               {
            //                                   Text = i.WorkerName,
            //                                   Value = i.WorkerId.ToString()
            //                               }).ToList();
            //ViewBag.vl3 = value3;

            return View();
        }

        [HttpPost]
        public ActionResult GiveLoaned(tblMovements p)
        {
            db.tblMovements.Add(p);
            db.SaveChanges();

            return View();
        }
    }
}