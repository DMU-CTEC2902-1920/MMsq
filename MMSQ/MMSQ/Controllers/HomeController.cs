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

        public ActionResult UnderConstruction()
        {
            return View();
        }

        public ActionResult TermsAndConditions()
        {
            ViewBag.Message = "Our Terms and Conditions";
            return View();
        }

        public ActionResult FAQHELP()
        {
            ViewBag.Message = "FAQ/HElP";
            return View();
        }

        public ActionResult Action()
        {
            ViewBag.Message = "ActionGames";
            return View();
        }

        public ActionResult Sport()
        {
            ViewBag.Message = "SportGames";
            return View();
        }

        public ActionResult FPS()
        {
            ViewBag.Message = "FPS";
            return View();
        }

        public ActionResult Developer()
        {
            ViewBag.Message = "Developer";
            return View();
        }
    }
}