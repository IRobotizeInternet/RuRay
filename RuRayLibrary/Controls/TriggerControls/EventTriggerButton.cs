using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRayToolbox.CommonControls;
using System;

namespace RuRayToolbox.Controls
{
    public class EventTriggerButton <EventResult>  where EventResult: class
    {
        private readonly BaseDOMProperty _element;
        private readonly RemoteWebDriver _driver;
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
