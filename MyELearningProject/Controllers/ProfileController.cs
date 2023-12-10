using MyELearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyELearningProject.Controllers
{
    public class ProfileController : Controller
    {
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            var value = Session["CurrentMail"];
            ViewBag.mail = Session["CurrentMail"];
            ViewBag.Name = context.Students.Where(x => x.Email == value).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            return View();
        }

        public ActionResult MyCourseList()
        {
            var value = Session["CurrentMail"];
            int id = context.Students.Where(x => x.Email == value).Select(y => y.StudentId).FirstOrDefault();
            ViewBag.name = context.Students.Where(x => x.Email == value).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            var courseList = context.Processes.Where(x => x.StudentId == id).ToList();
            return View(courseList);
        }

        [HttpGet]
        public ActionResult StudentPage()
        {
            var value = Session["CurrentMail"];
            ViewBag.mail = Session["CurrentMail"];
            ViewBag.name = context.Students.Where(x => x.Email == value).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}