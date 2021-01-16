using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace RobotizeFacebook.Pages.LoggedIn.MarketPlace.CreateNewListing
{
    public class PageCreateNewListing : PageBase
    {
        public override string PageUrl => "/marketplace/create";

        public PageCreateNewListing(RemoteWebDriver driver, WebDriverWait wait)
        {

        }
    }
}
