using OpenQA.Selenium;
using RobotizeFacebook.App.LoggedIn.Pages;

namespace RobotizeFacebook.App.NotLoggedIn
{
    public class PageCookies : BasePage
    {
        public override string PageUrl => "policies/cookies/";

        public override By ByForPage => throw new System.NotImplementedException();

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
