﻿using MyELearningProject.DAL.Context;
using MyELearningProject.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyELearningProject.Controllers
{
    public class CategoryController : Controller
    {
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            var values = context.Categories.ToList();
            TempData["BreadCrumb"] = "Kategoriler";
            return View(values);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCategory(int id)
        {
            var value = context.Categories.Find(id);
            context.Categories.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var value = context.Categories.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            var value = context.Categories.Find(category.CategoryId);
            value.CategoryName = category.CategoryName;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}