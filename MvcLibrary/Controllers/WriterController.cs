﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcLibrary.Models.Entity;

namespace MvcLibrary.Controllers
{
    public class WriterController : Controller
    {
        // GET: Writer
        DbLibraryEntities db = new DbLibraryEntities();

        public ActionResult Index()
        {
            var degerler = db.tblWriters.ToList();

            return View(degerler);
        }

        [HttpGet]
        public ActionResult AddWriter()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddWriter(tblWriters p)
        {
            db.tblWriters.Add(p);
            db.SaveChanges();

            return View();
        }

        public ActionResult DeleteWriter(int id)
        {
            var writer = db.tblWriters.Find(id);
            db.tblWriters.Remove(writer);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult GetWriter(int id)
        {
            var writer = db.tblWriters.Find(id);

            return View("GetWriter", writer);
        }

        public ActionResult UpdateWriter(tblWriters p)
        {
            var writer = db.tblWriters.Find(p.WriterId);
            writer.WriterName = p.WriterName;
            writer.WriterSurname = p.WriterSurname;
            writer.WriterDetail = p.WriterDetail;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}