using System;
using OpenQA.Selenium;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class PageUserTimeline : BasePage
    {
        public PageUserTimeline()
        {
        }

        public override string PageUrl => @"\";

        public override By ByForPage => throw new NotImplementedException();

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
