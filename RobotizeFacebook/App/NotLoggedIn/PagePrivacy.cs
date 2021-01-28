using OpenQA.Selenium;

namespace RobotizeFacebook.App.NotLoggedIn
{
    public class PagePrivacy : PageBase
    {
        public override string PageUrl => "about/privacy/update";

        public override By ByForPage => throw new System.NotImplementedException();

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
