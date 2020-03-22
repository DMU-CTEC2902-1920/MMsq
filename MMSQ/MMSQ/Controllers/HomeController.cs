using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

        public ActionResult Developers()
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
    }
}