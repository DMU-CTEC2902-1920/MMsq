using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MMSQ.Models
{
    public class clsGame
    {
        [Key]
        //Game Properties
        [Required]
        public virtual int GameID { get; set; }

        [Required]
        public virtual int GenreID { get; set; }

        [Required]
        [MinLength(3)][MaxLength(55)]
        public virtual string Genre_Name { get; set; }

        [Required]
        [MinLength(2)][MaxLength(50)]
        public string Game_GameTitle { get; set; }

        [Required]
        [MinLength(2)][MaxLength(3)]
        public virtual string Game_AgeRestriction { get; set; }

        [Required]
        public virtual bool Game_Multiplayer { get; set; }

        [Required]
        [MinLength(2)][MaxLength(55)]
        public virtual string Game_Platform { get; set; }

        [Required]
        public virtual DateTime Game_ReleaseDate { get; set; }

        [Required]
        public virtual int Game_Score { get; set; }

        [Required]
        [MinLength(2)][MaxLength(5000)]
        public virtual string Game_Description { get; set; }

        [Required]
        [MinLength(2)][MaxLength(2000)]
        public virtual string Game_Trailer { get; set; }

        public List<clsReview> Reviews { get; set; }

    }
}