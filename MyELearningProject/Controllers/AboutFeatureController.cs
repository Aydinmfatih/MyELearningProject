using MyELearningProject.DAL.Context;
using MyELearningProject.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyELearningProject.Controllers
{
    public class AboutFeatureController : Controller
    {
        ELearningContext context = new ELearningContext();

        public ActionResult Index()
        {
            var values = context.AboutFeatures.ToList();
            TempData["BreadCrumb"] = "Hakkımızda Öne çıkan";
            return View(values);
        }

        [HttpGet]
        public ActionResult AddAboutFeature()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAboutFeature(AboutFeature aboutFeature)
        {
            context.AboutFeatures.Add(aboutFeature);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DeleteAboutFeature(int id)
        {
            var value = context.AboutFeatures.Find(id);
            context.AboutFeatures.Remove(value);
            context.SaveChanges();
            return View();
        }

        [HttpGet]
        public ActionResult UpdateAboutFeature(int id)
        {
            var values = context.AboutFeatures.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateAboutFeature(AboutFeature aboutFeature)
        {
            var value = context.AboutFeatures.Find(aboutFeature.AboutFeatureId);
            value.AboutIcon = aboutFeature.AboutIcon;
            value.Description = aboutFeature.Description;
            value.Title = aboutFeature.Title;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}