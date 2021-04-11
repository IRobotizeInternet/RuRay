using OpenQA.Selenium;
using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PageCampus : BasePage
    {
        public override string PageUrl => "/campus";

        public override By ByForPage => throw new NotImplementedException();

        public PageCampus()
        {
        }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
