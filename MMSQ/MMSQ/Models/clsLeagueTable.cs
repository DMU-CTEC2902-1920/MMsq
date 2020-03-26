using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MMSQ.Models
{
    public class clsLeagueTable
    {
        [Required]
        public virtual int RankID { get; set; }

        [Required]
        [MinLength(3)][MaxLength(50)]
        public virtual string LT_GameTitle { get; set; }

        [Required]
        public virtual decimal LT_Score { get; set; }
    }
}