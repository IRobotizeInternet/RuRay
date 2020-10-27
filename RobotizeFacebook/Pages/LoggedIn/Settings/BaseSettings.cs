using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeFacebook.Pages.LoggedIn.Settings
{
    public class BaseSettings
    {
        internal RemoteWebDriver Driver;
        internal WebDriverWait Wait;
       
        internal BaseSettings() { }

        public BaseSettings(RemoteWebDriver driver, WebDriverWait wait)
        {
            Driver = driver;
            Wait = wait;
        }
    }
}
