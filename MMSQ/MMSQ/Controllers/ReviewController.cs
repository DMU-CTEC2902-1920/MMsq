using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MMSQ.Data;
using MMSQ.Models;

namespace MMSQ.Controllers
{
    public class ReviewController : Controller 
    {

        private GameContext db = new GameContext();

        // GET: Review
        public ActionResult Review()
        {
                return View(db.clsReviews.ToList()); 

            //return View(CreateReview());
        }

        public ActionResult ReviewsByGame()
        {
            return View(CreateReview());
        }

        //GET: Create Review
        private clsGame CreateReview()
        {
            clsGame GameDetails = new clsGame();
            GameDetails.GameID = 1;
            GameDetails.GenreID = 1;
            GameDetails.Genre_Name = "Sports";
            GameDetails.Game_GameTitle = "FIFA 19";
            GameDetails.Game_AgeRestriction = "3+";
            GameDetails.Game_Multiplayer = true;
            GameDetails.Game_Platform = "PS4";
            GameDetails.Game_ReleaseDate = Convert.ToDateTime("01/01/2020");
            GameDetails.Game_Score = 6;
            GameDetails.Game_Description = "EA Sports FIFA 19 delivers a champion - caliber experience on and off the pitch. Introducing the prestigious UEFA Champions League, offering authentic in-match atmospheres, featuring gameplay updates including elevated on-pitch personality and a striking overhaul, and providing new and unrivaled ways to play. Champions Rise in FIFA 19.";
            GameDetails.Game_Trailer = "https://www.youtube.com/watch?v=zX0AV6yxyr";

              GameDetails.Reviews = new List<clsReview>()
            {
                new clsReview {ReviewID = 1, Review_GameTitle = "FIFA 19", Review_ReviewDescription = "Not better than FIFA 18!!", Review_Score = 3, Review_ReviewStatus = true },
                new clsReview {ReviewID = 2, Review_GameTitle = "FIFA 19", Review_ReviewDescription = "Solid game but again, im a bit disappointed...", Review_Score = 6, Review_ReviewStatus = true },
                new clsReview {ReviewID = 3, Review_GameTitle = "FIFA 19", Review_ReviewDescription = "FIFA 19 continues being brilliant off the pitch, but this iteration also contains some really interesting gameplay enhancements for the soccer itself. Not a revolutionary game, but a nice evolution for the series. ", Review_Score = 9, Review_ReviewStatus = true },

            };
            return GameDetails;
        }

        // GET: Review/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Games/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReviewID,Review_GameTitle, Review_ReviewDescription,Review_Score,Review_ReviewStatus,clsGame_GameID")] clsReview clsReview)
        {
            if (ModelState.IsValid)
            {
                db.clsReviews.Add(clsReview);
                db.SaveChanges();
                return RedirectToAction("Review");
            }
            return View(clsReview);
        }

    }
}