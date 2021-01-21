using OpenQA.Selenium;

namespace RobotizeFacebook.App.NotLoggedIn
{
    public class PageCookies : PageBase
    {
        public override string PageUrl => "policies/cookies/";

        public override By ByForPage => throw new System.NotImplementedException();
    }
}
