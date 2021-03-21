﻿using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PageFriends : BasePage
    {
        public override string PageUrl => "/friends";

        public override By ByForPage => By.XPath($"//h1[text()='{ResCreatePost.Friends}']");

        public PageFriends()
        {
        }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
