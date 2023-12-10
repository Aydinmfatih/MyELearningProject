using MyELearningProject.DAL.Context;
using MyELearningProject.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyELearningProject.Controllers
{
    public class ContactController : Controller
    {
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            TempData["BreadCrumb"] = "Kategoriler";
            return View();
        }

        [HttpPost]
        public ActionResult SendMessage(Contact contact)
        {
            context.Contacts.Add(contact);
            context.SaveChanges();
            return View();
        }

        public ActionResult AdminContact()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }

        public ActionResult DeleteContact(int id)
        {
            var value = context.Contacts.Find(id);
            context.Contacts.Remove(value);
            return View();
            
        }
    }
}