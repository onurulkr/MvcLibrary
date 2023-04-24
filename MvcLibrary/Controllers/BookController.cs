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

        public ActionResult Index(string p)
        {
            var books = from b in db.tblBooks select b;
            if (!string.IsNullOrEmpty(p))
            {
                books = books.Where(x => x.BookName.Contains(p));
            }

            //var books = db.tblBooks.ToList();

            return View(books.ToList());
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
            var ctg = db.tblCategories.Where(x => x.CategoryId == p.tblCategories.CategoryId).FirstOrDefault();
            var writer = db.tblWriters.Where(x => x.WriterId == p.tblWriters.WriterId).FirstOrDefault();
            p.tblCategories = ctg;
            p.tblWriters = writer;
            db.tblBooks.Add(p);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult DeleteBook(int id)
        {
            var book = db.tblBooks.Find(id);
            db.tblBooks.Remove(book);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult GetBook(int id)
        {
            var book = db.tblBooks.Find(id);
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

            return View("GetBook", book);
        }

        public ActionResult UpdateBook(tblBooks p)
        {
            var book = db.tblBooks.Find(p.BookId);

            book.BookName = p.BookName;
            book.Year = p.Year;
            book.Publisher = p.Publisher;
            book.Page = p.Page;
            book.Status = true;

            var ctg = db.tblCategories.Where(x => x.CategoryId == p.tblCategories.CategoryId).FirstOrDefault();
            var writer = db.tblWriters.Where(y => y.WriterId == p.tblWriters.WriterId).FirstOrDefault();

            book.Category = ctg.CategoryId;
            book.Writer = writer.WriterId; 

            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
} 
