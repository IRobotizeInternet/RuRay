using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PageHelp : BasePage
    {
        public override string PageUrl => "/help/";

        public override By ByForPage => throw new System.NotImplementedException();

        public PageHelp(RemoteWebDriver driver)
        {

        }

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
