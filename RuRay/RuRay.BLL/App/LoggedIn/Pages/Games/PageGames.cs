using System;
using OpenQA.Selenium;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class PageGames : BasePage
    {
        public override string PageUrl => "/games";

        public override By ByForPage => throw new NotImplementedException();

        public PageGames()
        {
        }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
