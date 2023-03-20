using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcLibrary.Models.Entity;

namespace MvcLibrary.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        DbLibraryEntities db = new DbLibraryEntities();

        public ActionResult Index()
        {
            var values = db.tblCategories.ToList();

            return View(values);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(tblCategories p)
        {
            db.tblCategories.Add(p);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
 
        public ActionResult DeleteCategory(int id)
        {
            var category = db.tblCategories.Find(id);
            db.tblCategories.Remove(category);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult GetCategory(int id)
        {
            var ctg = db.tblCategories.Find(id);

            return View("GetCategory", ctg);
        }

        public ActionResult UpdateCategory(tblCategories p)
        {
            var ctg = db.tblCategories.Find(p.CategoryId);
            ctg.CategoryName = p.CategoryName;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    } 
}
