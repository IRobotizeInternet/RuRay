using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeToolbox.CommonControls;
using System;
using System.Threading;

namespace RobotizeToolbox.Controls.TriggerControls
{
    public class Hyperlink <EventResult> where EventResult : class
    {
        private readonly BaseDOMProperty _element;
        private readonly RemoteWebDriver _driver;
        private readonly WebDriverWait _wait;
        public Hyperlink(
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
            Thread.Sleep(5000);
            return (EventResult)Activator.CreateInstance(typeof(EventResult), _driver, _wait);
        }
    }
}
