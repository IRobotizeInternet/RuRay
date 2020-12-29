using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeToolbox.CommonControls;
using System;

namespace RobotizeToolbox.Controls.TriggerControls
{
    public class EventTriggerDiv<EventResult> where EventResult : class
    {
        private readonly BaseDOMProperty _element;
        private readonly RemoteWebDriver _driver;
        private readonly WebDriverWait _wait;

        public EventTriggerDiv(
            RemoteWebDriver driver, 
            WebDriverWait wait, 
            By byForElement)
        {
            _driver = driver;
            _wait = wait;
            _element = new BaseDOMProperty(driver, byForElement);
        }

        public EventResult Click()
        {
            _element.Click();
            return (EventResult)Activator.CreateInstance(typeof(EventResult), _driver, _wait);
        }
    }
}
