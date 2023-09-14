using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Entites
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string Name { get; set; }
        [StringLength(30)]
        public string Surname { get; set; }
        public string ImageUrl { get; set; }

    }
}