using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PagePrivacy : BasePage
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
