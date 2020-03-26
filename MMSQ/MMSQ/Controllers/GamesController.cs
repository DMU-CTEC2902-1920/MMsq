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
    public class GamesController : Controller
    {
        private GameContext db = new GameContext();

        // GET: Games
        public ActionResult Games()
        {
            return View(db.clsGames.ToList());
        }

        // GET: Games/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            clsGame clsGame = db.clsGames.Find(id);
            if (clsGame == null)
            {
                return HttpNotFound();
            }
            return View(clsGame);
        }

        // GET: Games/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Games/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GameID,GenreID,Genre_Name,Game_GameTitle,Game_AgeRestriction,Game_Multiplayer,Game_Platform,Game_ReleaseDate,Game_Score,Game_Description,Game_Trailer")] clsGame clsGame)
        {
            if (ModelState.IsValid)
            {
                db.clsGames.Add(clsGame);
                db.SaveChanges();
                return RedirectToAction("Games");
            }

            return View(clsGame);
        }

        // GET: Games/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            clsGame clsGame = db.clsGames.Find(id);
            if (clsGame == null)
            {
                return HttpNotFound();
            }
            return View(clsGame);
        }

        // POST: Games/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GameID,GenreID,Genre_Name,Game_GameTitle,Game_AgeRestriction,Game_Multiplayer,Game_Platform,Game_ReleaseDate,Game_Score,Game_Description,Game_Trailer")] clsGame clsGame)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clsGame).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Games");
            }
            return View(clsGame);
        }

        // GET: Games/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            clsGame clsGame = db.clsGames.Find(id);
            if (clsGame == null)
            {
                return HttpNotFound();
            }
            return View(clsGame);
        }

        // POST: Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            clsGame clsGame = db.clsGames.Find(id);
            db.clsGames.Remove(clsGame);
            db.SaveChanges();
            return RedirectToAction("Games");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
