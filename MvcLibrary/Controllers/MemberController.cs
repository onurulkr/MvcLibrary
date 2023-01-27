using MvcLibrary.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace MvcLibrary.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        DbLibraryEntities db = new DbLibraryEntities();

        public ActionResult Index(int page = 1)
        {
            //var values = db.tblMembers.ToList();
            var values = db.tblMembers.ToList().ToPagedList(page, 3);

            return View(values);
        }

        [HttpGet]
        public ActionResult AddMember()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMember(tblMembers p)
        {
            db.tblMembers.Add(p);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult DeleteMember(int id)
        {
            var member = db.tblMembers.Find(id);
            db.tblMembers.Remove(member);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult GetMember(int id)
        {
            var member = db.tblMembers.Find(id);

            return View("GetMember", member);
        }

        public ActionResult UpdateMember(tblMembers p)
        {
            var member = db.tblMembers.Find(p.MemberId);
            member.MemberName = p.MemberName;
            member.MemberSurname = p.MemberSurname;
            member.MemberMail = p.MemberMail;
            member.MemberUsername = p.MemberUsername;
            member.MemberPassword = p.MemberPassword;
            member.MemberSchool = p.MemberSchool;
            member.MemberPhone = p.MemberPhone;
            member.MemberImage = p.MemberImage;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}