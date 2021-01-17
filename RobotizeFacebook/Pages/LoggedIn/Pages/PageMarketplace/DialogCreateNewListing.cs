using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RobotizeFacebook.Pages.LoggedIn.MarketPlace.CreateNewListing
{
    public class DialogCreateNewListing : PageBase
    {
        public override string PageUrl => "/marketplace/create";

        public override By ByForPage => throw new System.NotImplementedException();

        public DialogCreateNewListing(RemoteWebDriver driver)
        {

        }
    }
}
