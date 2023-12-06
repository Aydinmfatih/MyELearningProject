using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Entites
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }

        public List<Course> Courses { get; set; }
    }
}