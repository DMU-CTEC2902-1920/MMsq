using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MMSQ.Models
{
    public class clsDeveloper
    {
        //Developer Properties
        [Required]
        public int DeveloperID { get; set; }

        [Required]
        [MinLength(2)][MaxLength(50)]
        public string Developer_DeveloperName { get; set; }

        [Required]
        public int Developer_GamesProduced { get; set; }
    }

    //Filter Method
    //public bool Filter(int DeveloperID)
    //{

    //}

    //Validation Method
    //public string Valid(string DeveloperID, string Developer_DeveloperName, string Developer_GamesProduced)
    //{
    //    return "";
    //}
}