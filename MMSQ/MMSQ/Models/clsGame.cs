using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MMSQ.Models
{
    public class clsGame
    {
        //Game Properties
        public int GameID { get; set; }

        public string Game_GameTitle { get; set; }

        public string Game_Genre { get; set; }

        public string Game_AgeRestriction { get; set; }

        public string Game_Developer { get; set; }

        public bool Game_Multiplayer { get; set; }

        public string Game_Platform { get; set; }

        public DateTime Game_ReleaseDate { get; set; }

        public string Game_Score { get; set; }
    }
}