using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class CellPhonesFilter : BaseFilter, ICellPhonesFilter, ICellPhonesFilterOptions
    {
        public CellPhonesFilter(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }
    }
}
