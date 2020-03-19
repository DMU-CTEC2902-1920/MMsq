using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MMSQ.Models;

namespace MMSQ.Models
{
    
    public class clsUser
    {
        //Private User Data Member
        //private int mUserID;

        //User Properties 
        [Required]
        public int UserID { get; set; }

        [Required]
        [MinLength(2)][MaxLength(50)]
        public string User_Username { get; set; }

        [Required]
        [MinLength(5)][MaxLength(25)]
        public string User_Password { get; set; }

        [Required]
        [MinLength(2)][MaxLength(50)]
        public string User_Firstname { get; set; }

        [Required]
        [MinLength(2)][MaxLength(50)]
        public string User_Lastname { get; set; }

        [Required]
        public bool User_Gender { get; set; }

        [Required]
        [MinLength(11)][MaxLength(13)]
        public string User_Telephone { get; set; }

        [Required]
        [MinLength(15)][MaxLength(50)]
        public string User_Email { get; set; }

        [Required]
        public DateTime User_DateOfBirth { get; set; }

        [Required]
        public bool User_AccountStatus { get; set; }

        public List<clsReview> GameReview { get; set; }
    }

    //Filter Method
    //public bool Filter(int UserID)
    //{
     
    //}
    
    //Validation Method
    //public string Valid(string User_Username, string User_Password, string User_Firstname, string User_Lastname, string User_Gender, string User_Telephone, string User_Email, string User_DateOfBirth, string User_AccountStatus)
    //{
    //    return "";
    //}


}