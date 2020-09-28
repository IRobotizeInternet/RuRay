using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeToolbox.CommonControls;
using System;

namespace RobotizeLibrary.CommonControls
{
    public class EventTriggerButton <EventResult>  where EventResult: class
    {
        private readonly BaseDOMProperty _element;
        private readonly RemoteWebDriver _driver;
        private readonly WebDriverWait _wait;

        public EventTriggerButton(RemoteWebDriver driver, WebDriverWait wait, By by)
        {
            _driver = driver;
            _wait = wait;
            _element = new BaseDOMProperty(driver, by);
        }

        public EventResult Click()
        {
            _element.Click();
            return (EventResult)Activator.CreateInstance(typeof(EventResult), _driver, _wait);
        }
    }
}
