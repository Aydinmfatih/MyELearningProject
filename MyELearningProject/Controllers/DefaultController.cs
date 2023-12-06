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


    }
}