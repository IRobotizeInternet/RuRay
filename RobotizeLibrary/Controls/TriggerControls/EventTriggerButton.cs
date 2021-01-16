using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeToolbox.CommonControls;
using System;

namespace RobotizeToolbox.Controls
{
    public class EventTriggerButton <EventResult>  where EventResult: class
    {
        private readonly BaseDOMProperty _element;
        private RemoteWebDriver _driver;
        public EventTriggerButton(
            RemoteWebDriver driver,
            By byForElement)
        {
            _driver = driver;
            _element = new BaseDOMProperty(driver, byForElement);
        }

        public EventResult Click()
        {
            _element.Click();
            return (EventResult)Activator.CreateInstance(typeof(EventResult), _driver);
        }
    }
}
