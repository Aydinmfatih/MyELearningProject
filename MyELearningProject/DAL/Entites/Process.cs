using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Entites
{
    public class Process
    {
        public int ProcessId { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        public  int CourseId { get; set; }
        public virtual Course Course { get; set; }

    }
}