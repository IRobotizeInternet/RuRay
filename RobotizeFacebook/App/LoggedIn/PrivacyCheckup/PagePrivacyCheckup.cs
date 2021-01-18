using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RobotizeFacebook.App.LoggedIn
{
    public class PagePrivacyCheckup : PageBase
    {
        public override string PageUrl => "/privacy/checkup/";

        public override By ByForPage => throw new System.NotImplementedException();

        public PagePrivacyCheckup(RemoteWebDriver driver)
        {

        }
    }
}
