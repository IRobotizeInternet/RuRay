using System;
using OpenQA.Selenium;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class PageMarketPlaceYourAccount : BasePage
    {
        public override string PageUrl => "/marketplace/you/selling";

        public override By ByForPage => throw new NotImplementedException();

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
