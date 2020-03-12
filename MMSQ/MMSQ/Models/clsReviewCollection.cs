using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MMSQ.Models
{
    public class clsReviewCollection
    {
        //Count Review
        public int Count { get; set; }

        //List Comments
        public List<clsReview> MyReview { get; set; }

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
        public List<clsReview> FilterReview = new List<clsReview>
        {

        };

        //Find Method
        public void Find(int ReviewID)
        {

        }
    }
}