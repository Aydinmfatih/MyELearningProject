using MyELearningProject.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Context
{
    public class ELearningContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Testimonial> Testimonials { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<CourseRegister> CourseRegisters { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Review> reviews { get; set; }

        public DbSet<About> Abouts { get; set; }

        public DbSet<AboutFeature> AboutFeatures { get; set; }

        public DbSet<AboutList> AboutLists { get; set; }

        public DbSet<CarousellFeature> CarousellFeatures { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        
        

    }
}