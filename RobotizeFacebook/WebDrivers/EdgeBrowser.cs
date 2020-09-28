﻿using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;
using System;

namespace RobotizeFacebook.WebDrivers
{
    public class EdgeBrowser: WebDriver
    {
        public EdgeBrowser(string baseUrl) : base(baseUrl) { }
        
        public override RemoteWebDriver Driver()
        {
            if (string.IsNullOrEmpty(BaseURL))
            {
                throw new Exception($"{nameof(BaseURL)} is not set.");
            }

            //set an option to disable 'Save Password' prompt in the browser
            var options = new EdgeOptions();
            options.AddAdditionalCapability("credentials_enable_service", false);
            options.AddAdditionalCapability("password_manager_enabled", false);
            options.UseInPrivateBrowsing = true;

            var driver = new EdgeDriver
            {
                Url = BaseURL
            };

            return driver;
        }
    }
}
