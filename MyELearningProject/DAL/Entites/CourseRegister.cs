using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Entites
{
    public class CourseRegister
    {
        public int CourseRegisterId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        [Column("Date")]
        public DateTime RegisterDate { get; set; }
    }
}