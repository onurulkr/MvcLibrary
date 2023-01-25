using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcLibrary.Models.Entity;

namespace MvcLibrary.Controllers
{
    public class WorkerController : Controller
    {
        // GET: Worker
        DbLibraryEntities db = new DbLibraryEntities();

        public ActionResult Index()
        {
            var degerler = db.tblWorkers.ToList();

            return View(degerler);
        }

        [HttpGet]
        public ActionResult AddWorker()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddWorker(tblWorkers p)
        {
            if (!ModelState.IsValid)
            {
                return View("AddWorker");
            }

            var worker = db.tblWorkers.Add(p);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}