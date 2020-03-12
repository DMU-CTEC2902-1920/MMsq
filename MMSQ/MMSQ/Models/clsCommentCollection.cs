using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MMSQ.Models
{
    public class clsCommentCollection
    {
        //Count Comment
        public int Count { get; set; }

        //List Comments
        public List<clsComment> MyComment { get; set; }

        //Add Method
        public int Add()
        {
            return 0;
        }

        //Edit Method
        public void Edit()
        {

        }

        //Delete Method
        public void Delete()
        {

        }

        //Filter Method
        public List<clsComment> FilterComment = new List<clsComment>
        {

        };

        //Find Method
        public void Find(int CommentID)
        {

        }
    }
}