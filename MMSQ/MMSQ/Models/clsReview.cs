using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MMSQ.Models;

namespace MMSQ.Models
{
    public class clsReview
    {
        //Review Properties
        [Required]
        public int ReviewID { get; set; }

        [Required]
        [MinLength(2)][MaxLength(50)]
        public string Review_GameTitle { get; set; }

        [Required]
        [MinLength(2)][MaxLength(100)]
        public string Review_ReviewDescription { get; set; }

        [Required]
        public bool Review_ReviewStatus { get; set; }

    }

    //Filter Method
    //public bool Filter(int ReviewID)
    //{

    //}

    //Validation Method
    //public string Valid(string Reiew_ReviewDescription, string Reiew_ReviewStatus)
    //{
    //    return "";
    //}
}