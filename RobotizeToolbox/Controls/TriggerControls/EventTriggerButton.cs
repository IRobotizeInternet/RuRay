using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.CommonControls;
using System;
using System.Threading;

namespace RobotizeToolbox.Controls
{
    public class EventTriggerButton <EventResult> : BaseDOMObject  where EventResult: class 
    {
        private readonly BaseDOMObject _element;
        private readonly string _xPath;

        public EventTriggerButton(
            RemoteWebDriver driver,
            By byForElement,
            string xPath = null) : base(driver, byForElement)
        {
            _xPath = xPath;
            _element = new BaseDOMObject(driver, byForElement);
        }

        public EventResult Click()
        {
            // TODO: We need to think about this things in future, othere it will cause significant delay. 
            _element.Click();
            Thread.Sleep(2500);
            return _xPath == null
                ? (EventResult)Activator.CreateInstance(typeof(EventResult), Driver)
                : (EventResult)Activator.CreateInstance(typeof(EventResult), _xPath);
        }

        public EventResult Hoverover()
        {
            // TODO: We need to think about this things in future, othere it will cause significant delay. 
            _element.MoveCursorToElement();
            Thread.Sleep(3000);
            return (EventResult)Activator.CreateInstance(typeof(EventResult), Driver);
        }
    }
}
