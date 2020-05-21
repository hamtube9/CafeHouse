using System;
using System.Collections.Generic;
using System.Text;

namespace CafeHouse.Models
{
   public class Reviews
    {
        public string Avatar { get; set; }
        public string NameUser { get; set; }

        public double Rate { get; set; }

        public string Content { get; set; }

        public List<ImageReview> ListImage { set; get; }
    }
}
