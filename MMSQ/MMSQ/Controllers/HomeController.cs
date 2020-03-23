using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MMSQ.Models;

namespace MMSQ.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GamesReview()
        {
            return View();
        }
        
        public ActionResult LeagueTable()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Us";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us";
            return View();
        }

        //GET: Action for rendering view
        public ActionResult SearchResult()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SearchResult(string SearchQuery)
        {
            ViewBag.SearchKey = SearchQuery;

            return View("Search Result", SearchQuery);
        }

        public ActionResult UnderConstruction()
        {
            return View();
        }

        public ActionResult TermsAndConditions()
        {
            ViewBag.Message = "Our Terms and Conditions";
            return View();
        }

        // GET: Developer
        public ActionResult Developers()
        {
            List<clsDeveloper> dev = new List<clsDeveloper>
            {
                new clsDeveloper { DeveloperID=1, Developer_DeveloperName="EA Sports", Developer_GamesProduced=5 },
                new clsDeveloper { DeveloperID=2, Developer_DeveloperName="Activison", Developer_GamesProduced=3 },
                new clsDeveloper { DeveloperID=3, Developer_DeveloperName="2K Sports", Developer_GamesProduced=4 },
                new clsDeveloper { DeveloperID=4, Developer_DeveloperName="Ubisoft", Developer_GamesProduced=4 },
                new clsDeveloper { DeveloperID=5, Developer_DeveloperName="Rockstar Games", Developer_GamesProduced=2 }
            };

            ViewData.Model = dev;

            return View();
        }

        // GET: Developer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Developer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Developer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Developer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Developer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Developer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Developer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        //public ActionResult Developers()
        //{
        //    return View();
        //}
    }
}