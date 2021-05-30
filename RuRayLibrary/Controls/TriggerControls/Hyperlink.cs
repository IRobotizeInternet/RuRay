using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRayToolbox.CommonControls;
using System;
using System.Threading;

namespace RuRayToolbox.Controls.TriggerControls
{
    public class Hyperlink <EventResult> where EventResult : class
    {
        private readonly RemoteWebDriver _driver;
        private readonly BaseDOMProperty _element;
        public Hyperlink(
            RemoteWebDriver driver,
            By byForElement)
        {
            _driver = driver;
            _element = new BaseDOMProperty(driver, byForElement);
        }

        public EventResult Click()
        {
            _element.Click();
            Thread.Sleep(5000);
            return (EventResult)Activator.CreateInstance(typeof(EventResult), _driver);
        }
    }
}
