﻿using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeToolbox.CommonControls;
using System;

namespace RobotizeLibrary.Controls.TriggerControls
{
    public class EventTriggerHyperlink <EventResult> where EventResult : class
    {
        private readonly BaseDOMProperty _element;

        public EventTriggerHyperlink(
            RemoteWebDriver driver,
            WebDriverWait wait, 
            By byForElement)
        {
            _element = new BaseDOMProperty(driver, byForElement);
        }

        public EventResult Click()
        {
            _element.Click();
            return (EventResult)Activator.CreateInstance(typeof(EventResult));
        }
    }
}
