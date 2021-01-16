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
        private WebDriverWait _wait;
        public ButtonNotificationSettings(RemoteWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }
        public EventTriggerButton<popupNotificationSettings>
            Button => new EventTriggerButton<popupNotificationSettings>(_driver, _wait, By.XPath($"//div[@aria-label='{ResNotificationSettings.EditNotificationSettings}'])"));
    }
}
