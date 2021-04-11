using OpenQA.Selenium;
using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PageStories : BasePage
    {
        public override string PageUrl => "/stories";

        public override By ByForPage => throw new NotImplementedException();

        public PageStories()
        {
        }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
