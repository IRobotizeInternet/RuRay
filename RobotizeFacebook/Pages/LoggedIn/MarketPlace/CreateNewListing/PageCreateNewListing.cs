using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
