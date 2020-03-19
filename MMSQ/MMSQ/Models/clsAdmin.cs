using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MMSQ.Models
{
    public class clsAdmin
    {
        //Admin Properties
        [Required]
        public int AdminID { get; set; }

        [Required]
        [MinLength(2)][MaxLength(50)]
        public string Admin_Firstname { get; set; }

        [Required]
        [MinLength(2)] [MaxLength(50)]
        public string Admin_Lastname { get; set; }

        [Required]
        public bool Admin_Gender { get; set; }

        [Required]
        [MinLength(15)][MaxLength(50)]
        public string Admin_Email { get; set; }
        [Required]
        [MinLength(4)][MaxLength(25)]
        public string Admin_Password { get; set; }

        [Required]
        [MinLength(11)][MaxLength(13)]
        public string Admin_Telephone { get; set; }
    }

    //Filter Method
    //public bool Filter(int AdminID)
    //{

    //}

    //Validation Method
    //public string Valid(string Admin_Firstname, string Admin_Lastname. string Amdin_Gender, string Admin_Email, string Admin_Password, string Admin_Telephone)
    //{
    //    return "";
    //}
}