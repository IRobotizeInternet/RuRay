using OpenQA.Selenium;
using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
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
