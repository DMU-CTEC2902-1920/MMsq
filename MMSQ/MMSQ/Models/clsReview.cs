using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MMSQ.Models
{
    public class clsReview
    {
        //Review Properties
        public int ReviewID { get; set; }

        public string Reiew_ReviewDescription { get; set; }

        public bool Reiew_ReviewStatus { get; set; }

        public int Reiew_ReviewUser { get; set; }
    }
}