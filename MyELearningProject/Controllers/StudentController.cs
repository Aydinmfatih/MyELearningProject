using MyELearningProject.DAL.Context;
using MyELearningProject.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyELearningProject.Controllers
{
  
    public class StudentController : Controller
    {
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            var values = context.Students.ToList();
            TempData["BreadCrumb"] = "Öğrenciler";
            return View(values);
        }
        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public ActionResult DeleteStudent(int id)
        {
            var value = context.Students.Find(id);
            context.Students.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateStudent(int id)
        {
            var value = context.Students.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateStudent(Student student)
        {
            var value = context.Students.Find(student.StudentId);
            value.Name = student.Name;
            value.Surname = student.Surname;
            value.Email = student.Email;
            value.Password = student.Password;
            context.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}