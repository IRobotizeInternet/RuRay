using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class PageHelp : PageBase
    {
        public override string PageUrl => "/help/";

        public override By ByForPage => throw new System.NotImplementedException();

        public PageHelp(RemoteWebDriver driver)
        {

        }
    }
}
