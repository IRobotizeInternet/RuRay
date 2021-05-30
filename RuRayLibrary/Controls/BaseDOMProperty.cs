﻿using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

using Polly;
using RuRayToolbox.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace RuRayToolbox.CommonControls
{
    public class BaseDOMProperty
    {
        protected By ByForElement;
        protected RemoteWebDriver Driver;

        public BaseDOMProperty(RemoteWebDriver driver, By byForElement)
        {
            ByForElement = byForElement;
            Driver = driver;
        }

        public BaseDOMProperty(RemoteWebDriver driver)
        {
            Driver = driver;
        }

        /// <summary>
        /// Check whether or not the element exists
        /// </summary>
        public bool IsDOMObjectExist => Driver.TryFindElement(ByForElement, out _);

        /// <summary>
        /// This method will try to click on the element atleast five times.
        /// </summary>
        public virtual void Click(int numberOfTries = 5)
        {
            // Adding delay to avoid rapid action avoid account being disabled. 
            Thread.Sleep(2000);
            
            // It will try to five seconds to click on an element.
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            try
            {
                // find the element
                var element = Driver.FindElementWithTimeSpan(ByForElement, timeSpanInSeconds: 10);

                // Using Polly library: https://github.com/App-vNext/Polly
                var policy = Policy
                  .Handle<InvalidOperationException>()
                  .WaitAndRetry(30, t => TimeSpan.FromSeconds(1));

                policy.Execute(() =>
                {
                    element.Click();
                });
            }
            catch (WebDriverException ex)
            {
                // If any of the following execptions occured try again.
                var knowErrorMessages = new List<string>
                    {
                        "not clickable at point",
                        "element is not attached",
                        "Timed out"
                    };

                if (knowErrorMessages.Any(x => x.Contains(ex.Message))) numberOfTries--;
                else throw new Exception($"Unexpected WebDriverException was encountered: {ex.Message} {ex.StackTrace}");
            }
        }

        /// <summary>
        /// Clear value.
        /// Select All + Backspace
        /// </summary>
        public void Clear()
        {
            var elementToClear = Driver.FindElementWithTimeSpan(ByForElement);
            elementToClear.SendKeys(Keys.Control + "a");
            elementToClear.SendKeys(Keys.Backspace);
            elementToClear.Clear();
        }

        /// <summary>
        /// Set value into an elements like a textbox for textarea. It also takes a 
        /// boolean flag to replace or append to the current value. 
        /// </summary>
        public void SetData(string valueToEnter, bool overwrite = true)
        {
            var startTime = DateTime.Now;
            var timeSpanInSeconds = 30;
            var finishedSettingValue = true;
            while (finishedSettingValue)
            {
                try
                {
                    var elementToSendKeys = Driver.FindElementWithTimeSpan(ByForElement);

                    if (overwrite) Clear();

                    elementToSendKeys.SendKeys(valueToEnter);
                    finishedSettingValue = !finishedSettingValue;
                }
                catch (InvalidElementStateException ex)
                {
                    throw new Exception($"Invalid element state exception occured: {ex.Message} {ex.StackTrace}");
                }

                // Throw when time span finished when setting up the value. 
                var timeElapsed = (DateTime.Now - startTime).TotalSeconds;
                if (timeElapsed >= timeSpanInSeconds) throw new TimeoutException($"Time out exception occured after: {timeSpanInSeconds} seconds.");
            }
        }

        /// <summary>
        /// Gets text property of an element
        /// </summary>
        public string GetText()
        {
            var gettingElementText = true;
            var totalAttempts = 10;
            var attempts = totalAttempts;
            var elementText = string.Empty;

            while (gettingElementText)
            {
                if (attempts == 0)
                {
                    throw new Exception("Unable to get text from " +
                                        $"element {ByForElement} after {totalAttempts} tries.");
                }

                try
                {
                    elementText = Driver.FindElementWithTimeSpan(ByForElement, 20).Text;
                    gettingElementText = false;
                }
                catch (WebDriverException ex)
                {
                    //try again if the element is stale or if there's a timeout
                    var staleElementError = "element is not attached";
                    var timeoutError = "Timed out after";

                    if (ex.Message.Contains(staleElementError) ||
                        ex.Message.Contains(timeoutError))
                    {
                        attempts--;
                    }
                    else
                    {
                        throw new Exception($"An unexpected WebDriverException was encountered: {ex.StackTrace}");
                    }
                }
            }

            return elementText;
        }

        public void ScrollToElement(IWebElement webElement = null)
        {
            var jScript = "arguments[0].scrollIntoView(false);" +
            "var evObj = document.createEvent('MouseEvents');" +
            "evObj.initMouseEvent(\"mouseover\",true, false, window, 0, 0, 0, 0, 0, false, false, false, false, 0, null);" +
            "arguments[0].dispatchEvent(evObj);";

            var element = Driver.FindElementWithTimeSpan(ByForElement);
            var targetElement = LocateScrollableElement(Driver, element);
            Driver.ExecuteScript(jScript, targetElement);
        }

        private static IWebElement LocateScrollableElement(RemoteWebDriver driver, IWebElement firstElement)
        {
            var ancestors = firstElement.FindElements(By.XPath("./ancestor-or-self::*")).Reverse();
            var scrollableElement = ancestors.FirstOrDefault(element => !element.Location.IsEmpty);
            return scrollableElement;
        }
    }
}
