using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MMsqGameReview.Models
{
    public class clsAdmin
    {
        public int AdminID { get; set; }

        public string Admin_Firstname { get; set; }

        public string Admin_Lastname { get; set; }

        public bool Admin_Gender { get; set; }

        public string Admin_Email { get; set; }

        public string Admin_Password { get; set; }

        public string Admin_Telephone { get; set; }
    }
}