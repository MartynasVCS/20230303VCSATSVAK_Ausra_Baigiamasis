﻿using NUnit.Framework;
using Framework.Pages.w3schools;
using Framework;
using NUnit.Framework.Interfaces;

namespace Tests.w3schoolsTests
{
    internal class w3schoolsHomepage
    {
        [SetUp]

        public void SetUp()
        {
            Driver.InitializeDriver();
            Homepage.Open();
        
            Homepage.AcceptCookies();
        }

        [Test]

        public void CheckHomepage()
        {
            //string expectedTutorials = "Tutorials";
            //string actualTutorials = Homepage.GetTutorialsButtonText();
            //Assert.AreEqual(expectedTutorials, actualTutorials);

            //string expectedReferences = "References";
            //string actualReferences = Homepage.GetReferencesButtonText();
            //Assert.AreEqual(expectedReferences, actualReferences);

            //string expectedExercises = "Exercises";
            //string actualExercises = Homepage.GetExercisesButtonText();
            //Assert.AreEqual(expectedExercises, actualExercises);

            //string expectedBootcamps = "Bootcamps";
            //string actualBootcamps = Homepage.GetBootcampsButtonText();
            //Assert.AreEqual(expectedBootcamps, actualBootcamps);

            //string expectedVideos = "Videos";
            //string actualVideos = Homepage.GetVideosButtonText();
            //Assert.AreEqual(expectedVideos, actualVideos);

            //string expectedUpgrade = "Upgrade";
            //string actualUpgrade = Homepage.GetUpgradeButtonText();
            //Assert.AreEqual(expectedUpgrade, actualUpgrade);

            //string expectedGetCertified = "Get Certified";
            //string actualGetCertified = Homepage.GetGetCertifiedButtonText();
            //Assert.AreEqual(expectedGetCertified, actualGetCertified);

            //string expectedCreateWebsite = "Create Website";
            //string actualCreateWebsite = Homepage.GetCreateWebsiteButtonText();
            //Assert.AreEqual(expectedCreateWebsite, actualCreateWebsite);

            //string expectedSignUp = "Sign Up";
            //string actualSignUp = Homepage.GetSignUpButtonText();
            //Assert.AreEqual(expectedSignUp, actualSignUp);

            //string expectedLogIn = "Log in";
            //string actualLogIn = Homepage.GetLogInButtonText();
            //Assert.AreEqual(expectedLogIn, actualLogIn);

            //string expectedDarkMenu = "Dark mode\r\nDark code";
            //string actualDarkMenu = Homepage.GetDarkMenuButtonText();
            //Assert.AreEqual(expectedDarkMenu, actualDarkMenu);

            //string expectedModeValue = "Dark mode";
            //string expectedCodeValue = "Dark code";
            //string actualModeValue = Homepage.GetDarkModeButtonText();
            //string actualCodeValue = Homepage.GetDarkCodeButtonText();            
            //Assert.AreEqual(expectedModeValue, actualModeValue);
            //Assert.AreEqual(expectedCodeValue, actualCodeValue);

            //string expectedGlobeButtnon = "";
            //string actualGlobeButton = Homepage.GetGlobeButtonText();
            //Assert.AreEqual(expectedGlobeButtnon, actualGlobeButton);
            string expectedLanguageFrame = "Pasirinkti kalbą";
            string actualLanguageFrame = Homepage.GetLanguages();
            Assert.AreEqual(expectedLanguageFrame, actualLanguageFrame);


        }


       
        //Homepage.ClickGlobeButton();
        //Homepage.ClickSearchButton();

        ////Paieskos laukas
        //Homepage.ClickNotSureLink();
        //Homepage.ClickSearchOurTutorialsLink();

        public void TearDown()
        {
            //if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            //{
            //    string screenshotFilePath = Driver.TakeScreenshot(TestContext.CurrentContext.Test.MethodName);
            //    TestContext.AddTestAttachment(screenshotFilePath);
            //}
            //Driver.ShutDownDriver();
        }
    }
}