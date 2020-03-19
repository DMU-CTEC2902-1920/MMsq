using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MMSQ.Models
{
    public class clsDeveloperCollection
    {
        //Count Developers
        public int Count { get; set; }

        //List Developers
        public List<clsDeveloper> MyDeveloper { get; set; }
    }
}