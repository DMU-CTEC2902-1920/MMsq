using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MMsqGameReview.Models
{
    public class clsReview
    {
        public int ReviewID { get; set; }

        public string Reiew_ReviewDescription { get; set; }

        public bool Reiew_ReviewStatus { get; set; }

        public int Reiew_ReviewUser { get; set; }
    }
}