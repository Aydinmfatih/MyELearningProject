using MyELearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyELearningProject.Controllers
{
    public class DefaultController : Controller
    {
        ELearningContext contex = new ELearningContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialFeatureCarousell()
        {
            var values = contex.CarousellFeatures.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialServices()
        {
            var values = contex.AboutFeatures.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAboutUs()
        {
            var values = contex.Abouts.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAboutList()
        {
            var values = contex.AboutLists.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialCategory()
        {
            var values = contex.Categories.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialCourse()
        {
            var values = contex.Courses.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialInstructor()
        {
            var values = contex.Instructors.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTestimonial()
        {
            var values = contex.Testimonials.ToList();
            return PartialView(values);
        }





    }
}