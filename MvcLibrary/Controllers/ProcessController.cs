using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcLibrary.Models.Entity;

namespace MvcLibrary.Controllers
{
    public class ProcessController : Controller
    {
        // GET: Process
        DbLibraryEntities db = new DbLibraryEntities();

        public ActionResult Index()
        {
            var values = db.tblMovements.Where(x => x.Status == true).ToList();

            return View(values);
        }
    }
} 
