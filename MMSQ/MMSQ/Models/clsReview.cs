using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MMSQ.Models
{
    public class clsReview
    {
        //Review Properties
        [Required]
        public int ReviewID { get; set; }

        [Required]
        [MinLength(2)][MaxLength(100)]
        public string Reiew_ReviewDescription { get; set; }

        [Required]
        public bool Reiew_ReviewStatus { get; set; }

        [Required]
        public virtual int UserID { get; set; }

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