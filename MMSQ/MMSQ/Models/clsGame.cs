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


        //[Required]
        //[MinLength(3)][MaxLength(50)]
        //public virtual string Genre_Name { get; set; }

        //[Required]
        //public virtual int DeveloperID { get; set; }

        //[Required]
        //public virtual int UserID { get; set; }

        //[Required]
        //public virtual int ReviewID { get; set; }

        //[Required]
        //public virtual int CommentID { get; set; }

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
    }


    //Filter Method
    //public bool Filter(int GameID)
    //{

    //}

    //Validation Method
    //public string Valid(string Game_GameTitle, string Game_Genre, string Game_AgeRestriction, string Game_Multiplayer, string Game_Platform, string Game_ReleaseDate, string Game_Score)
    //{
    //    return "";
    //}
}