using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MMSQ.Models;

namespace MMSQ.Models
{
    public class clsReview
    {
        [Key]
        //Review Properties
        [Required]
        public virtual int ReviewID { get; set; }

        [Required]
        [MinLength(2)][MaxLength(50)]
        public virtual string Review_GameTitle { get; set; }

        [Required]
        [MinLength(2)][MaxLength(100)]
        public virtual string Review_ReviewDescription { get; set; }

        [Required]
        public virtual int  Review_Score { get; set; }

        [Required]
        public bool Review_ReviewStatus { get; set; }

    }
}