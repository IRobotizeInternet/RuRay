using OpenQA.Selenium;
using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PageWatch : BasePage
    {
        public override string PageUrl => "/watch";

        public override By ByForPage => throw new NotImplementedException();

        public PageWatch()
        {
        }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
