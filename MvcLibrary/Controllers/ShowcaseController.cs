using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcLibrary.Models.Entity;
using MvcLibrary.Models.MyClasses;

namespace MvcLibrary.Controllers
{
    public class ShowcaseController : Controller
    {
        // GET: Showcase
        DbLibraryEntities db = new DbLibraryEntities();

        [HttpGet]
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Value1 = db.tblBooks.ToArray();
            cs.Value2 = db.tblAbouts.ToArray();
            //var values = db.tblBooks.ToList();

            return View(cs);
        }

        [HttpPost]
        public ActionResult Index(tblContacts t)
        {
            db.tblContacts.Add(t);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}