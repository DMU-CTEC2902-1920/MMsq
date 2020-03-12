using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MMSQ.Models
{
    public class clsGame
    {
        //Game Properties
        [Required]
        public int GameID { get; set; }

        [Required]
        public virtual int DeveloperID { get; set; }

        [Required]
        public virtual int UserID { get; set; }

        [Required]
        public virtual int ReviewID { get; set; }

        [Required]
        public virtual int CommentID { get; set; }

        [Required]
        [MinLength(2)][MaxLength(50)]
        public string Game_GameTitle { get; set; }

        [Required]
        [MinLength(2)][MaxLength(55)]
        public string Game_Genre { get; set; }

        [Required]
        [MinLength(2)][MaxLength(3)]
        public string Game_AgeRestriction { get; set; }

        [Required]
        public bool Game_Multiplayer { get; set; }

        [Required]
        [MinLength(2)][MaxLength(55)]
        public string Game_Platform { get; set; }

        [Required]
        public DateTime Game_ReleaseDate { get; set; }

        [Required]
        public int Game_Score { get; set; }
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