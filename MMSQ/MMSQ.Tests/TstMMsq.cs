using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MMSQ.Models;

namespace MMsqGameReview.Tests
{
    [TestClass]
    public class MMsqGamesReview
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the clsUser class
            clsUser AUser = new clsUser();
            //test to see that it exists
            Assert.IsNotNull(AUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the clsUser class
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AUser.UserID = TestData;
            //test to see that it exists
            Assert.AreEqual(AUser.UserID, TestData);
        }

        [TestMethod]
        public void User_UsernamePropertyOK()
        {
            //create an instance of the clsUser class
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            string TestData = "Username1";
            //assign the data to the property
            AUser.User_Username = TestData;
            //test to see that it exists
            Assert.AreEqual(AUser.User_Username, TestData);
        }

        [TestMethod]
        public void User_PasswordPropertyOK()
        {
            //create an instance of the clsUser class
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            string TestData = "Password";
            //assign the data to the property
            AUser.User_Password = TestData;
            //test to see that it exists
            Assert.AreEqual(AUser.User_Password, TestData);
        }

        [TestMethod]
        public void User_FirstnamePropertyOK()
        {
            //create an instance of the clsUser class
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            string TestData = "Mark";
            //assign the data to the property
            AUser.User_Firstname = TestData;
            //test to see that it exists
            Assert.AreEqual(AUser.User_Firstname, TestData);
        }

        [TestMethod]
        public void User_LastnamePropertyOK()
        {
            //create an instance of the clsUser class
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            string TestData = "Paul";
            //assign the data to the property
            AUser.User_Lastname = TestData;
            //test to see that it exists
            Assert.AreEqual(AUser.User_Lastname, TestData);
        }

        [TestMethod]
        public void User_GenderPropertyOK()
        {
            //create an instance of the clsUser class
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AUser.User_Gender = TestData;
            //test to see that it exists
            Assert.AreEqual(AUser.User_Gender, TestData);
        }

        [TestMethod]
        public void User_TelephonePropertyOK()
        {
            //create an instance of the clsUser class
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            string TestData = "01844 654319";
            //assign the data to the property
            AUser.User_Telephone = TestData;
            //test to see that it exists
            Assert.AreEqual(AUser.User_Telephone, TestData);
        }

        [TestMethod]
        public void User_EmailPropertyOK()
        {
            //create an instance of the clsUser class
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            string TestData = "UserTest@gmail.com";
            //assign the data to the property
            AUser.User_Email = TestData;
            //test to see that it exists
            Assert.AreEqual(AUser.User_Email, TestData);
        }

        [TestMethod]
        public void User_DateOfBirthPropertyOK()
        {
            //create an instance of the clsUser class
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            DateTime TestData = Convert.ToDateTime("04/11/1997");
            //assign the data to the property
            AUser.User_DateOfBirth = TestData;
            //test to see that it exists
            Assert.AreEqual(AUser.User_DateOfBirth, TestData);
        }

        [TestMethod]
        public void User_AccountStatusPropertyOK()
        {
            //create an instance of the clsUser class
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AUser.User_AccountStatus = TestData;
            //test to see that it exists
            Assert.AreEqual(AUser.User_AccountStatus, TestData);
        }

        [TestMethod]
        public void AdminIDPropertyOK()
        {
            //create an instance of the clsUser class
            clsAdmin AnAdmin = new clsAdmin();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAdmin.AdminID = TestData;
            //test to see that it exists
            Assert.AreEqual(AnAdmin.AdminID, TestData);
        }

        [TestMethod]
        public void Admin_FirstnamePropertyOK()
        {
            //create an instance of the clsUser class
            clsAdmin AnAdmin = new clsAdmin();
            //create some test data to assign to the property
            string TestData = "Mark";
            //assign the data to the property
            AnAdmin.Admin_Firstname = TestData;
            //test to see that it exists
            Assert.AreEqual(AnAdmin.Admin_Firstname, TestData);
        }

        [TestMethod]
        public void Admin_LastnamePropertyOK()
        {
            //create an instance of the clsUser class
            clsAdmin AnAdmin = new clsAdmin();
            //create some test data to assign to the property
            string TestData = "Paul";
            //assign the data to the property
            AnAdmin.Admin_Lastname = TestData;
            //test to see that it exists
            Assert.AreEqual(AnAdmin.Admin_Lastname, TestData);
        }

        [TestMethod]
        public void Admin_GenderPropertyOK()
        {
            //create an instance of the clsUser class
            clsAdmin AnAdmin = new clsAdmin();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnAdmin.Admin_Gender = TestData;
            //test to see that it exists
            Assert.AreEqual(AnAdmin.Admin_Gender, TestData);
        }

        [TestMethod]
        public void Admin_EmailPropertyOK()
        {
            //create an instance of the clsUser class
            clsAdmin AnAdmin = new clsAdmin();
            //create some test data to assign to the property
            string TestData = "admintest@gmal.com";
            //assign the data to the property
            AnAdmin.Admin_Email = TestData;
            //test to see that it exists
            Assert.AreEqual(AnAdmin.Admin_Email, TestData);
        }

        [TestMethod]
        public void Admin_PasswordPropertyOK()
        {
            //create an instance of the clsUser class
            clsAdmin AnAdmin = new clsAdmin();
            //create some test data to assign to the property
            string TestData = "Password";
            //assign the data to the property
            AnAdmin.Admin_Password = TestData;
            //test to see that it exists
            Assert.AreEqual(AnAdmin.Admin_Password, TestData);
        }

        [TestMethod]
        public void Admin_TelephonePropertyOK()
        {
            //create an instance of the clsUser class
            clsAdmin AnAdmin = new clsAdmin();
            //create some test data to assign to the property
            string TestData = "01844 323974";
            //assign the data to the property
            AnAdmin.Admin_Telephone = TestData;
            //test to see that it exists
            Assert.AreEqual(AnAdmin.Admin_Telephone, TestData);
        }

        [TestMethod]
        public void CommentIDPropertyOK()
        {
            //create an instance of the clsUser class
            clsComment AComment = new clsComment();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AComment.CommentID = TestData;
            //test to see that it exists
            Assert.AreEqual(AComment.CommentID, TestData);
        }

        [TestMethod]
        public void Comment_CommentDescriptionPropertyOK()
        {
            //create an instance of the clsUser class
            clsComment AComment = new clsComment();
            //create some test data to assign to the property
            string TestData = "Great!";
            //assign the data to the property
            AComment.Comment_CommentDescription = TestData;
            //test to see that it exists
            Assert.AreEqual(AComment.Comment_CommentDescription, TestData);
        }

        [TestMethod]
        public void Comment_CommentStatusPropertyOK()
        {
            //create an instance of the clsUser class
            clsComment AComment = new clsComment();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AComment.Comment_CommentStatus = TestData;
            //test to see that it exists
            Assert.AreEqual(AComment.Comment_CommentStatus, TestData);
        }

        [TestMethod]
        public void DeveloperIDPropertyOK()
        {
            //create an instance of the clsUser class
            clsDeveloper ADeveloper = new clsDeveloper();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ADeveloper.DeveloperID = TestData;
            //test to see that it exists
            Assert.AreEqual(ADeveloper.DeveloperID, TestData);
        }

        [TestMethod]
        public void Developer_DeveloperNamePropertyOK()
        {
            //create an instance of the clsUser class
            clsDeveloper ADeveloper = new clsDeveloper();
            //create some test data to assign to the property
            string TestData = "Mark";
            //assign the data to the property
            ADeveloper.Developer_DeveloperName = TestData;
            //test to see that it exists
            Assert.AreEqual(ADeveloper.Developer_DeveloperName, TestData);
        }

        [TestMethod]
        public void Developer_DeveloperGamesProducedPropertyOK()
        {
            //create an instance of the clsUser class
            clsDeveloper ADeveloper = new clsDeveloper();
            //create some test data to assign to the property
            Int32 TestData = 10;
            //assign the data to the property
            ADeveloper.Developer_GamesProduced = TestData;
            //test to see that it exists
            Assert.AreEqual(ADeveloper.Developer_GamesProduced, TestData);
        }

        [TestMethod]
        public void ReviewIDPropertyOK()
        {
            //create an instance of the clsUser class
            clsReview AReview = new clsReview();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AReview.ReviewID = TestData;
            //test to see that it exists
            Assert.AreEqual(AReview.ReviewID, TestData);
        }

        [TestMethod]
        public void Reiew_ReviewDescriptionPropertyOK()
        {
            //create an instance of the clsUser class
            clsReview AReview = new clsReview();
            //create some test data to assign to the property
            string TestData = "Good!";
            //assign the data to the property
            AReview.Review_ReviewDescription = TestData;
            //test to see that it exists
            Assert.AreEqual(AReview.Review_ReviewDescription, TestData);
        }

        [TestMethod]
        public void Reiew_ReviewStatusPropertyOK()
        {
            //create an instance of the clsUser class
            clsReview AReview = new clsReview();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AReview.Review_ReviewStatus = TestData;
            //test to see that it exists
            Assert.AreEqual(AReview.Review_ReviewStatus, TestData);
        }

        [TestMethod]
        public void Reiew_ReviewUserPropertyOK()
        {
            //create an instance of the clsUser class
            clsReview AReview = new clsReview();
            //create some test data to assign to the property
            Int32 TestData = 8;
            //assign the data to the property
            AReview.Review_Score = TestData;
            //test to see that it exists
            Assert.AreEqual(AReview.Review_Score, TestData);
        }

        [TestMethod]
        public void GameIDPropertyOK()
        {
            //create an instance of the clsUser class
            clsGame AGame = new clsGame();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AGame.GameID = TestData;
            //test to see that it exists
            Assert.AreEqual(AGame.GameID, TestData);
        }

        [TestMethod]
        public void Game_GameTitlePropertyOK()
        {
            //create an instance of the clsUser class
            clsGame AGame = new clsGame();
            //create some test data to assign to the property
            string TestData = "Fifa";
            //assign the data to the property
            AGame.Game_GameTitle = TestData;
            //test to see that it exists
            Assert.AreEqual(AGame.Game_GameTitle, TestData);
        }

        [TestMethod]
        public void Game_GenreNamePropertyOK()
        {
            //create an instance of the clsUser class
            clsGame AGame = new clsGame();
            //create some test data to assign to the property
            string TestData = "Sports";
            //assign the data to the property
            AGame.Genre_Name = TestData;
            //test to see that it exists
            Assert.AreEqual(AGame.Genre_Name, TestData);
        }

        [TestMethod]
        public void Game_AgeRestrictionPropertyOK()
        {
            //create an instance of the clsUser class
            clsGame AGame = new clsGame();
            //create some test data to assign to the property
            string TestData = "4";
            //assign the data to the property
            AGame.Game_AgeRestriction = TestData;
            //test to see that it exists
            Assert.AreEqual(AGame.Game_AgeRestriction, TestData);
        }


        [TestMethod]
        public void Game_MultiplayerPropertyOK()
        {
            //create an instance of the clsUser class
            clsGame AGame = new clsGame();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AGame.Game_Multiplayer = TestData;
            //test to see that it exists
            Assert.AreEqual(AGame.Game_Multiplayer, TestData);
        }

        [TestMethod]
        public void Game_PlatformPropertyOK()
        {
            //create an instance of the clsUser class
            clsGame AGame = new clsGame();
            //create some test data to assign to the property
            string TestData = "PS4";
            //assign the data to the property
            AGame.Game_Platform = TestData;
            //test to see that it exists
            Assert.AreEqual(AGame.Game_Platform, TestData);
        }

        [TestMethod]
        public void Game_ReleaseDatePropertyOK()
        {
            //create an instance of the clsUser class
            clsGame AGame = new clsGame();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AGame.Game_ReleaseDate = TestData;
            //test to see that it exists
            Assert.AreEqual(AGame.Game_ReleaseDate, TestData);
        }

        [TestMethod]
        public void Game_ScorePropertyOK()
        {
            //create an instance of the clsUser class
            clsGame AGame = new clsGame();
            //create some test data to assign to the property
            int TestData = 10;
            //assign the data to the property
            AGame.Game_Score = TestData;
            //test to see that it exists
            Assert.AreEqual(AGame.Game_Score, TestData);
        }
    }
}




