using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeLibrary.Controls;
using RobotizeToolbox.Controls;

namespace RobotizeLibrary.Components
{
    public abstract class UpperHalf
    {
        private RemoteWebDriver _driver;
        private WebDriverWait _wait;
        public EventTriggerButton<DialogLeftMenuSettings> LeftMenuSettingsButton => new EventTriggerButton<DialogLeftMenuSettings>(_driver, _wait, By.XPath());
        public virtual Combobox SearchBox;

        public UpperHalf(RemoteWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }
    }
}