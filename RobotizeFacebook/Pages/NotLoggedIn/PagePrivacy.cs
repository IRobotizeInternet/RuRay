using OpenQA.Selenium;

namespace RobotizeFacebook.Pages.NotLoggedIn
{
    public class PagePrivacy : PageBase
    {
        public override string PageUrl => "about/privacy/update";

        public override By ByForPage => throw new System.NotImplementedException();
    }
}
