using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.CommonControls;
using System;
using System.Threading;

namespace RobotizeToolbox.Controls
{
    public class EventTriggerButton <EventResult>  where EventResult: class
    {
        private readonly BaseDOMObject _element;
        private readonly string _xPath;

        public EventTriggerButton(
            RemoteWebDriver driver,
            By byForElement,
            string xPath = null)
        {
            _xPath = xPath;
            _element = new BaseDOMObject(driver, byForElement);
        }

        public EventResult Click()
        {
            _element.Click();
            return _xPath == null
                ? (EventResult)Activator.CreateInstance(typeof(EventResult))
                : (EventResult)Activator.CreateInstance(typeof(EventResult), _xPath);
        }

        public void Hoverover()
        {
            Thread.Sleep(3000);
            _element.MoveCursorToElement();
        }
    }
}
