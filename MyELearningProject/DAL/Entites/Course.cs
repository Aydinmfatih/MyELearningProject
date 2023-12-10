using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Entites
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Duration { get; set; }
        public string ImageUrl { get; set; }


       
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int InstructorId { get; set; }
        public virtual Instructor Instructor { get; set; }

        public List<CourseRegister> CourseRegisters { get; set; }

        public List<Comment> Comment { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Process> Processes { get; set; }
    }
}