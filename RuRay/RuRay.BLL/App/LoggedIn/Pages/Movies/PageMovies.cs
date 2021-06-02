using System;
using OpenQA.Selenium;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class PageMovies : BasePage
    {
        public override string PageUrl => "/movies";

        public override By ByForPage => throw new NotImplementedException();

        public PageMovies()
        {
        }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
