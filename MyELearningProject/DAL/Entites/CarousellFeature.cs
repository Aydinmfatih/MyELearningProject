using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Entites
{
    public class CarousellFeature
    {
        public int CarousellFeatureId { get; set; }
        public string Title { get; set; }
        public string Title2 { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}