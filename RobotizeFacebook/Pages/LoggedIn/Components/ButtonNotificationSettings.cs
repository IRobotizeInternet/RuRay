using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.Pages.LoggedIn.CommonComponents
{
    public abstract class ButtonNotificationSettings
    {
        private RemoteWebDriver _driver;
        public ButtonNotificationSettings(RemoteWebDriver driver)
        {
            _driver = driver;
        }
        //public EventTriggerButton<popupNotificationSettings>
        //    Button => new EventTriggerButton<popupNotificationSettings>(_driver);
    }
}
