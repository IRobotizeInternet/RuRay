using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RobotizeFacebook.App
{
    public class PagePrivacy : PageBase
    {
        public override string PageUrl => "/privacy/";

        public override By ByForPage => throw new System.NotImplementedException();

        public PagePrivacy(RemoteWebDriver driver)
        {

        }

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
