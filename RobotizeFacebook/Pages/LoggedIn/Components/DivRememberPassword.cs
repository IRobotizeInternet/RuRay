using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeFacebook.Pages.LoggedIn.Components
{
    public class DivRememberPassword
    {
        private RemoteWebDriver _driver;
        private string _basePath = $"//span[text()='{ResMiscellaneous.DivRememberPassword}']/../../../../../..";
        public DivRememberPassword(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        public Button ButtonOK => new Button(_driver, By.XPath($"{_basePath}//span[text()='{ResMiscellaneous.OK}']"));
        public Button ButtonNotNow => new Button(_driver, By.XPath($"{_basePath}//span[text()='{ResMiscellaneous.NotNow}']"));
    }
}
