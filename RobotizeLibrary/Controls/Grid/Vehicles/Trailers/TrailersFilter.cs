using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;

namespace RobotizeLibrary.Controls.Grid
{
    public class TrailersFilter : BaseFilter, ITrailersFilter, ITrailersFilterOptions
    {
        public TrailersFilter(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }
       
    }
}
