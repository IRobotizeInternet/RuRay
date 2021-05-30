using OpenQA.Selenium;
using RuRayFacebook.App.LoggedIn.Pages;

namespace RuRayFacebook.App.NotLoggedIn.Help
{
    public class PageHelpChooseALegacyContact : BasePage
    {
        public override string PageUrl => "/help";

        public override By ByForPage => throw new System.NotImplementedException();

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
