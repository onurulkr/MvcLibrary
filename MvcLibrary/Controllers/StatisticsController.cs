using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcLibrary.Controllers
{
    public class StatisticsController : Controller
    {
        // GET: Statistics
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Weather()
        {
            return View();
        }

        public ActionResult WeatherCard()
        {
            return View();
        }
 
        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult UploadImage(HttpPostedFileBase file)
        {
            if (file.ContentLength > 0)
            {
                string filePath = Path.Combine(Server.MapPath("~/statistics/images/"), Path.GetFileName(file.FileName));
                file.SaveAs(filePath);
            }

            return RedirectToAction("Gallery");
        }
    }
}
