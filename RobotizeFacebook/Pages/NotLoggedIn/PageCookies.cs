using OpenQA.Selenium;

namespace RobotizeFacebook.Pages.NotLoggedIn
{
    public class PageCookies : PageBase
    {
        public override string PageUrl => "policies/cookies/";

        public override By ByForPage => throw new System.NotImplementedException();
    }
}
