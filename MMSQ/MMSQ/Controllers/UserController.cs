using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MMSQ.Models;

namespace MMSQ.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View(CreateUser());
        }

        private clsUser CreateUser()
        {
            clsUser NewUser = new clsUser();
            NewUser.UserID = 1;
            NewUser.User_Username = "BestGamer";
            NewUser.User_Password = "Password123";
            NewUser.User_Firstname = "Paul";
            NewUser.User_Lastname = "Pogba";
            NewUser.User_Telephone = "123456789123";
            NewUser.User_Email = "PP6@gmail.com";
            NewUser.User_DateOfBirth = Convert.ToDateTime("01/01/2020");
            NewUser.User_AccountStatus = true;

            NewUser.GameReview = new List<clsReview>()
            {
                new clsReview {ReviewID = 1, Review_GameTitle = "FIFA 20", Review_ReviewDescription = "Not better than FIFA 19!!", Review_ReviewStatus = true },
                new clsReview {ReviewID = 2, Review_GameTitle = "Call Of Duty: Modern Warfare", Review_ReviewDescription = "SOOOO Epic. Great game!!", Review_ReviewStatus = true},
                new clsReview {ReviewID = 3, Review_GameTitle = "Tom Clancy: Rainbow Six Siege", Review_ReviewDescription = "was an improvement from the last game", Review_ReviewStatus = true}
            };
            return NewUser;
        }
    }
}