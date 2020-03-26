using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MMSQ.Models
{
    public class clsGenre
    {
        [Key]
        public virtual int GenreID { get; set; }
        public virtual string Genre_Name { get; set; }
    }
}