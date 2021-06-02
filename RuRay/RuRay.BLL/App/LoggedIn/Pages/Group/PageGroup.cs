using System;
using OpenQA.Selenium;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class PageGroup : BasePage
    {
        public override string PageUrl => "/groups/feed/";

        public override By ByForPage => throw new NotImplementedException();

        public PageGroup()
        {
        }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
