using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class CondosForRentFilter : BaseFilter, ICondosForRentFilter, ICondosForRentFilterOptions
    {
        public CondosForRentFilter(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }
    }
}
