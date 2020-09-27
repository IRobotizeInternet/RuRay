using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeToolbox.CommonControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeLibrary.CommonControls
{
    public class EventTriggerHyperlink <EventResult> where EventResult : class
    {
        private readonly BaseDOMProperty _element;
        private readonly RemoteWebDriver _driver;
        private readonly WebDriverWait _wait;

        public EventTriggerHyperlink(RemoteWebDriver driver, WebDriverWait wait, By by)
        {
            _driver = driver;
            _wait = wait;
            _element = new BaseDOMProperty(driver, by);
        }

        public EventResult Click()
        {
            _element.Click();
            return (EventResult)Activator.CreateInstance(typeof(EventResult));
        }
    }
}
