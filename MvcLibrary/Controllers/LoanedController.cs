﻿using MvcLibrary.Models.Entity;
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
            var values = db.tblMovements.Where(x => x.Status == false).ToList();

            return View(values);
        }

        [HttpGet]
        public ActionResult GiveLoaned()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GiveLoaned(tblMovements p)
        {
            db.tblMovements.Add(p);
            db.SaveChanges();

            return View();
        }

        public ActionResult ReturnLoaned(int id)
        {
            var loaned = db.tblMovements.Find(id);

            return View("ReturnLoaned", loaned);
        }

        public ActionResult UpdateLoaned(tblMovements p)
        {
            var movement = db.tblMovements.Find(p.MovementId);
            movement.MemberGiveDate = p.MemberGiveDate;
            movement.Status = true;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}