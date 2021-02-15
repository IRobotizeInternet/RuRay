using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PageSettings : BasePage
    {
        public override string PageUrl => "/settings/";

        public override By ByForPage => throw new System.NotImplementedException();

        public PageSettings(RemoteWebDriver driver)
        {
        }

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
