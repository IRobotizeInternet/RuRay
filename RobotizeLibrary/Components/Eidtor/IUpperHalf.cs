using OpenQA.Selenium.Remote;

namespace RobotizeLibrary.Components
{
    public abstract class UpperHalf
    {
        private readonly RemoteWebDriver _driver;
        
        //public EventTriggerButton<DialogLeftMenuSettings> LeftMenuSettingsButton => new EventTriggerButton<DialogLeftMenuSettings>(_driver, _wait, By.XPath());
        //public virtual Combobox SearchBox;

        public UpperHalf(RemoteWebDriver driver)
        {
            _driver = driver;

        }
    }
}