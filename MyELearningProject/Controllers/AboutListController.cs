using MyELearningProject.DAL.Context;
using MyELearningProject.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyELearningProject.Controllers
{
    public class AboutListController : Controller
    {
        ELearningContext context = new ELearningContext();

        public ActionResult Index()
        {
            var values = context.AboutLists.ToList();
            TempData["BreadCrumb"] = "Hakkımızda Listesi";
            return View(values);
        }

        [HttpGet]
        public ActionResult AddAboutList()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAboutList(AboutList aboutList)
        {
            context.AboutLists.Add(aboutList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeleteAboutList(int id)
        {
            var values = context.AboutLists.Find(id);
            context.AboutLists.Remove(values);
            context.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult UpdateAboutList(int id)
        {
            var values = context.AboutLists.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateAboutList(AboutList aboutList)
        {
            var value = context.AboutLists.Find(aboutList.AboutListId);
            value.AboutListTitle = aboutList.AboutListTitle;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}