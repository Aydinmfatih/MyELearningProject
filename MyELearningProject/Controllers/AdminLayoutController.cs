using MyELearningProject.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyELearningProject.Controllers
{
    public class AdminLayoutController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        } 
        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialRowPageTitle()
        {
            ViewBag.Breadcrumb = new List<BreadcrumbItem>
        {
            new BreadcrumbItem { Text = "Ana Sayfa", Url = Url.Action("Index", "Home") },
            new BreadcrumbItem { Text = "Kategoriler", Url = Url.Action("Index", "Category") },
            new BreadcrumbItem { Text = "Kurslar", Url = Url.Action("Index", "Course") }
        };

           

            return PartialView();
        }
        public PartialViewResult PartialPreloader()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }



    }
}