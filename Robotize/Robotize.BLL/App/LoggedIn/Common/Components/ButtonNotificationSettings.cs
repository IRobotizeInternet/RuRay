﻿using OpenQA.Selenium.Remote;

namespace RuRayFacebook.App.LoggedIn.CommonComponents
{
    public abstract class ButtonNotificationSettings
    {
        private readonly RemoteWebDriver _driver;
        public ButtonNotificationSettings(RemoteWebDriver driver)
        {
            _driver = driver;
        }
        //public EventTriggerButton<popupNotificationSettings>
        //    Button => new EventTriggerButton<popupNotificationSettings>(_driver);
    }
}
