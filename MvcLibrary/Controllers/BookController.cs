using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcLibrary.Models.Entity;

namespace MvcLibrary.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        DbLibraryEntities db = new DbLibraryEntities();

        public ActionResult Index()
        {
            var books = db.tblBooks.ToList();

            return View(books);
        }

        [HttpGet]
        public ActionResult AddBook()
        {
            List<SelectListItem> value1 = (from i in db.tblCategories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.CategoryName,
                                               Value = i.CategoryId.ToString()
                                           }).ToList();
            ViewBag.vl1 = value1;

            List<SelectListItem> value2 = (from i in db.tblWriters.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.WriterName + ' ' + i.WriterSurname,
                                               Value = i.WriterId.ToString()
                                           }).ToList();
            ViewBag.vl2 = value2;

            return View();
        }

        [HttpPost]
        public ActionResult AddBook(tblBooks p)
        {
            return View();
        }
    }
}