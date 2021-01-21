using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RobotizeFacebook.App.LoggedIn
{
    public class PageUserHome : PageBase
    {
        public PageUserHome(RemoteWebDriver driver)
        {
        }

        public override string PageUrl => "{0}";

        public override By ByForPage => throw new System.NotImplementedException();
    }
}
