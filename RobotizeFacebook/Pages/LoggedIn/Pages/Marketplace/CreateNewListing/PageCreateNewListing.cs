using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RobotizeFacebook.Pages.LoggedIn.MarketPlace.CreateNewListing
{
    public class PageCreateNewListing : PageBase
    {
        public override string PageUrl => "/marketplace/create";

        public override By ByForPage => throw new System.NotImplementedException();

        public PageCreateNewListing(RemoteWebDriver driver)
        {

        }
    }
}
