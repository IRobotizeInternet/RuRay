using OpenQA.Selenium;
using RuRayFacebook.App.LoggedIn.Pages;

namespace RuRayFacebook.App.NotLoggedIn
{
    public class PagePrivacy : BasePage
    {
        public override string PageUrl => "about/privacy/update";

        public override By ByForPage => throw new System.NotImplementedException();

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
