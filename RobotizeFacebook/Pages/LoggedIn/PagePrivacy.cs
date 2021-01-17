using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RobotizeFacebook.Pages
{
    public class PagePrivacy : PageBase
    {
        public override string PageUrl => "/privacy/";

        public override By ByForPage => throw new System.NotImplementedException();

        public PagePrivacy(RemoteWebDriver driver)
        {

        }
    }
}
