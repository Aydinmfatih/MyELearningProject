﻿using MyELearningProject.DAL.Context;
using MyELearningProject.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyELearningProject.Controllers
{
    public class TestimonialController : Controller
    {
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            TempData["BreadCrumb"] = "Referanslar";
            var values = context.Testimonials.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTestimonial(Testimonial testimonial)
        {
            context.Testimonials.Add(testimonial);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeleteTestimonial(int id)
        {
            var value = context.Testimonials.Find(id);
            context.Testimonials.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var value = context.Testimonials.Find(id);
            return View(value);

        }
        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial testimonial)
        {
            var value = context.Testimonials.Find(testimonial.TestimonialId);
            value.NameSurname = testimonial.NameSurname;
            value.Title = testimonial.Title;
            value.ImageUrl = testimonial.ImageUrl;
            value.Comment = testimonial.Comment;
            value.Status = testimonial.Status;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}