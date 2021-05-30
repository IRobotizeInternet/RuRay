using OpenQA.Selenium;
using System;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class PageFundraisers : BasePage
    {
        public override string PageUrl => "/fundraisers";

        public override By ByForPage => throw new NotImplementedException();

        public PageFundraisers()
        {
        }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
