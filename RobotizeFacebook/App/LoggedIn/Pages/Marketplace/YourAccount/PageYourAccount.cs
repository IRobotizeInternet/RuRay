using OpenQA.Selenium;
using System;

namespace RobotizeFacebook.App.LoggedIn.Pages.Marketplace.YourAccount
{
    public class PageYourAccount : BasePage
    {
        public override string PageUrl => "/marketplace/you/selling";

        public override By ByForPage => throw new NotImplementedException();

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
