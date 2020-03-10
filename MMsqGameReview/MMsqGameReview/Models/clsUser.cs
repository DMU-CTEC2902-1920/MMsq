using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MMsqGameReview.Models
{
    public class clsUser
    {
        public int UserID { get; set; }

        public string User_Username { get; set; }

        public string User_Password { get; set; }

        public string User_Firstname { get; set; }

        public string User_Lastname { get; set; }

        public bool User_Gender { get; set; }

        public string User_Telephone { get; set; }

        public string User_Email { get; set; }

        public string User_DateOfBirth { get; set; }

        public string User_AccountStatus { get; set; }
    }
}