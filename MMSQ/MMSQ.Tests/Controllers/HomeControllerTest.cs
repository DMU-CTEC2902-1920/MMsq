using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MMSQ;
using MMSQ.Controllers;

namespace MMSQ.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("About Us", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void UnderConstruction()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.UnderConstruction() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TermsAndConditions()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.TermsAndConditions() as ViewResult;

            // Assert
            Assert.AreEqual("Our Terms and Conditions", result.ViewBag.Message);
        }

        [TestMethod]
        public void FAQHELP()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.FAQHELP() as ViewResult;

            // Assert
            Assert.AreEqual("FAQ/HElP", result.ViewBag.Message);
        }

        [TestMethod]
        public void Action()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Action() as ViewResult;

            // Assert
            Assert.AreEqual("ActionGames", result.ViewBag.Message);
        }

        [TestMethod]
        public void Sport()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Sport() as ViewResult;

            // Assert
            Assert.AreEqual("SportGames", result.ViewBag.Message);
        }


        [TestMethod]
        public void FPS()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.FPS() as ViewResult;

            // Assert
            Assert.AreEqual("FPS", result.ViewBag.Message);
        }

        [TestMethod]
        public void Developer()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Developer() as ViewResult;

            // Assert
            Assert.AreEqual("Developer", result.ViewBag.Message);
        }
    }
}
