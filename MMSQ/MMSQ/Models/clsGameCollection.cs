using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MMSQ.Models
{
    public class clsGameCollection
    {
        //Count Game
        public int Count { get; set; }

        //List Comments
        public List<clsGame> MyGame { get; set; }

        //Add Method
        public int Add()
        {
            return 0;
        }

        //Edit Method
        public void Edit()
        {

        }

        //Delete Method
        public void Delete()
        {

        }

        //Filter Method
        public List<clsGame> FilterGame = new List<clsGame>
        {

        };

        //Find Method
        public void Find(int GameID)
        {

        }
    }
}