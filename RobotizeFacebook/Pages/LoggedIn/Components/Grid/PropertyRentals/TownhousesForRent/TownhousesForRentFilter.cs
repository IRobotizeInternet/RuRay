using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class TownhousesForRentFilter : BaseFilter, ITownhousesForRentFilter, ITownhousesForRentFilterOptions
    {
        public TownhousesForRentFilter(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }
    }
}
