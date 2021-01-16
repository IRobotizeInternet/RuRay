using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace RobotizeFacebook.Pages.LoggedIn.MarketPlace.CreateNewListing
{
    public class DialogCreateNewListing : PageBase
    {
        public override string PageUrl => "/marketplace/create";

        public DialogCreateNewListing(RemoteWebDriver driver, WebDriverWait wait)
        {

        }
    }
}
