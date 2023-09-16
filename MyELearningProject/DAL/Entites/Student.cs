using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Entites
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public List<CourseRegister> CourseRegisters { get; set; }
    }
}