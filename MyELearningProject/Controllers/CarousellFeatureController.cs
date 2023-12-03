using MyELearningProject.DAL.Context;
using MyELearningProject.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyELearningProject.Controllers
{
    public class CarousellFeatureController : Controller
    {
        ELearningContext context = new ELearningContext();

        public ActionResult Index()
        {
            var values = context.CarousellFeatures.ToList();
            TempData["BreadCrumb"] = "Kaydırmalı öne çıkan";
            return View(values);
        }

        [HttpGet]
        public ActionResult AddCarousellFeature()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCarousellFeature(CarousellFeature carousellFeature)
        {
            context.CarousellFeatures.Add(carousellFeature);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeleteCarousellFeature(int id)
        {
            var values = context.CarousellFeatures.Find(id);
            context.CarousellFeatures.Remove(values);
            context.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult UpdateCarousellFeature(int id)
        {
            var values = context.CarousellFeatures.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateCarousellFeature(CarousellFeature carousellFeature)
        {
            var value = context.CarousellFeatures.Find(carousellFeature.CarousellFeatureId);
            value.Title = carousellFeature.Title;
            value.Description = carousellFeature.Description;
            value.Title2 = carousellFeature.Title2;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}