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
            var values = db.tblWorkers.ToList();

            return View(values);
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

        public ActionResult DeleteWorker(int id)
        {
            var worker = db.tblWorkers.Find(id);
            db.tblWorkers.Remove(worker);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult GetWorker(int id)
        {
            var worker = db.tblWorkers.Find(id);

            return View("GetWorker", worker);
        }

        public ActionResult UpdateWorker(tblWorkers p)
        {
            var worker = db.tblWorkers.Find(p.WorkerId);
            worker.WorkerName = p.WorkerName;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}