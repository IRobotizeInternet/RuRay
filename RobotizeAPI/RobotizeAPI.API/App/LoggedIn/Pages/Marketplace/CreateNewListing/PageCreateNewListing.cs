using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PageCreateNewListing : BasePage
    {
        public override string PageUrl => "/marketplace/create";

        public override By ByForPage => throw new System.NotImplementedException();

        public PageCreateNewListing(RemoteWebDriver driver)
        {

        }

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
