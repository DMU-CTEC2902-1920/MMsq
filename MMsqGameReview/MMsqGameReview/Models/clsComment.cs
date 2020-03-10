using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MMsqGameReview.Models
{
    public class clsComment
    {
        public int CommentID { get; set; }
        public string Comment_CommentDescription { get; set; }
        public bool Comment_CommentStatus { get; set; }
        public int Comment_CommentUser { get; set; }
    }
}