using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Entites
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int CourseId { get; set; }
        public Course Course  { get; set; }
        public int StudentId { get; set; }
        public Student student { get; set; }
        public int ReviewScore { get; set; }
    }
}