﻿using Framework.Pages.w3schools;
using Framework;
using NUnit.Framework;

namespace Tests.w3schoolsTests
{
    internal class w3schoolsLogInPage

    {
        [SetUp]

        public void SetUp()
        {
            Driver.InitializeDriver();
            LogIn.Open();

            LogIn.AcceptCookies();
        }

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
