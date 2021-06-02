using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRayToolbox.CommonControls;

namespace RuRayToolbox.Controls.TriggerControls
{
    public class EventTriggerDiv<EventResult> where EventResult : class
    {
        private readonly BaseDOMObject _element;
        private readonly RemoteWebDriver _driver;
        public EventTriggerDiv(
            RemoteWebDriver driver,
            By byForElement)
        {
            _driver = driver;
            _element = new BaseDOMObject(driver, byForElement);
        }

        public EventResult Click()
        {
            _element.Click();
            return (EventResult)Activator.CreateInstance(typeof(EventResult), _driver);
        }
    }
}
