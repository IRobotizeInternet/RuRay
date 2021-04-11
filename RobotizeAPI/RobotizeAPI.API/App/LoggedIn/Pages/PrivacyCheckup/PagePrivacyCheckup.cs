using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PagePrivacyCheckup : BasePage
    {
        public override string PageUrl => "/privacy/checkup/";

        public override By ByForPage => throw new System.NotImplementedException();

        public PagePrivacyCheckup(RemoteWebDriver driver)
        {

        }

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
