using System;
using OpenQA.Selenium;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class PageEvents : BasePage
    {
        public override string PageUrl => "/events";

        public override By ByForPage => throw new NotImplementedException();

        public PageEvents()
        {
        }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
