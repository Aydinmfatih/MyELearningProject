using MyELearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyELearningProject.Controllers
{
    public class InstructorAnalysisController : Controller
    {
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult InstructorPanelPartial()
        {
            int id = 2;
            var v1 = context.Instructors.Where(x => x.Name == "Ahmet" && x.Surname == "Ölçen").Select(y => y.InstructorId).FirstOrDefault();
            var v2 = context.Courses.Where(x => x.InstructorId == v1).Select(y => y.CourseId).ToList();

    
            var values = context.Instructors.Where(x => x.InstructorId == id).ToList();
            ViewBag.commentCount = context.Comments.Where(x => v2.Contains(x.CourseId)).Count();
            ViewBag.courseCount = context.Courses.Where(x => x.InstructorId == 1).Count();
            return PartialView(values);
        }
        public PartialViewResult CommentPartial()
        {
            var v1 = context.Instructors.Where(x => x.Name == "Ahmet" && x.Surname == "Ölçen").Select(y => y.InstructorId).FirstOrDefault();
            var v2 = context.Courses.Where(x => x.InstructorId == v1).Select(y => y.CourseId).ToList();
            var v3 = context.Comments.Where(x => v2.Contains(x.CourseId)).ToList();
          
            ViewBag.commentCount = context.Comments.Where(x => v2.Contains(x.CourseId)).Count();
            return PartialView(v3);
        }

        public PartialViewResult CourseListByInstructor()
        {
            var v1 = context.Courses.Where(x => x.InstructorId == 1).ToList();
            return PartialView(v1);
        }
    }
}