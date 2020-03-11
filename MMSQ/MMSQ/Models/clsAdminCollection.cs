using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MMSQ.Models
{
    public class clsAdminCollection
    {
        //Count Admin
        public int Count { get; set; }

        //List Developers
        public List<clsAdmin> MyAdmin { get; set; }
    }
}