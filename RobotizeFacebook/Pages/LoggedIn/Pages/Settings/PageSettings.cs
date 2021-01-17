using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RobotizeFacebook.Pages
{
    public class PageSettings : PageBase
    {
        public override string PageUrl => "/settings/";

        public override By ByForPage => throw new System.NotImplementedException();

        public PageSettings(RemoteWebDriver driver)
        {
        }
    }
}
