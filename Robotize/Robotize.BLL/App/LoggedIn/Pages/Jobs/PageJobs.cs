using OpenQA.Selenium;
using System;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class PageJobs : BasePage
    {
        public override string PageUrl => "/jobs/?source=bookmark";

        public override By ByForPage => throw new NotImplementedException();

        public PageJobs()
        {
        }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
