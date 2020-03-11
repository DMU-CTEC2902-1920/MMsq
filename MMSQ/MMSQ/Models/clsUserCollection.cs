using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MMSQ.Models
{
    public class clsUserCollection
    {
        //Count Users
        public int Count { get; set; }

        //List Users
        public List<clsUser> UserList { get; set; }

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
        public List<clsUser> FilterUser = new List<clsUser>
        {

        };

        //Find Method
        public void Find(int UserID)
        {

        }
    }
}