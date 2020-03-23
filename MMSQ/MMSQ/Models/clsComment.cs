using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MMSQ.Models
{
    public class clsComment
    {
        //Comment Properties   
        [Required]
        public int CommentID { get; set; }

        [Required]
        [MinLength(2)][MaxLength(100)]
        public string Comment_CommentDescription { get; set; }

        [Required]
        public bool Comment_CommentStatus { get; set; }

        [Required]
        public virtual int UserID { get; set; }
    }

    //Filter Method
    //public bool Filter(int CommentID)
    //{

    //}

    //Validation Method
    //public string Valid(string Comment_CommentDescription, string Comment_CommentStatus)
    //{
    //    return "";
    //}
}