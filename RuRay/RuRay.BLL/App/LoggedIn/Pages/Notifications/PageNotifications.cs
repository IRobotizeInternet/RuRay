using System;
using OpenQA.Selenium;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class PageNotifications : BasePage
    {
        public override string PageUrl => "/notifications";

        public override By ByForPage => throw new NotImplementedException();

        public PageNotifications()
        {
        }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
