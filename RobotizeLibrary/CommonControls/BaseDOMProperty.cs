using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeLibrary.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RobotizeToolbox.CommonControls
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

        /// <summary>
        /// Check whether or not the element exists
        /// </summary>
        public bool IsDOMObjectExist => Driver.TryFindElement(ByForElement, out _);

        /// <summary>
        /// This method will try to click on the element atleast five times.
        /// </summary>
        public virtual void Click(int numberOfTries = 5)
        {
            // It will try to five seconds to click on an element.
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            var isElementClicked = false;
            while (!isElementClicked)
            {
                if (numberOfTries == 0) throw new Exception($"Unable to click element {ByForElement}");

                try
                {
                    // find the element
                    var element = Driver.FindElementWithTimeSpan(ByForElement, timeSpanInSeconds: 20);
                    element.Click();
                    isElementClicked = !isElementClicked;
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
            var finishedSettingValue = false;
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
    }
}
