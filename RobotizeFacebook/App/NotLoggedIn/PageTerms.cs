﻿using OpenQA.Selenium;

namespace RobotizeFacebook.App.NotLoggedIn
{
    public class PageTerms : PageBase
    {
        public override string PageUrl => "legal/terms/update";

        public override By ByForPage => throw new System.NotImplementedException();
    }
}