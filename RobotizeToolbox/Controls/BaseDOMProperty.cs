using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;

using Polly;
using RobotizeToolbox.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            // If any of the following execptions occured try again.
            var knowErrorMessages = new List<string>
                {
                        "not clickable at point",
                        "element is not attached",
                        "Timed out"
                };

            // Using Polly library: https://github.com/App-vNext/Polly
            var policy = Policy
              .Handle<InvalidOperationException>()
              .WaitAndRetry(numberOfTries, timespan => TimeSpan.FromSeconds(10));

            var element = Driver.FindElementWithTimeSpan(ByForElement, timeSpanInSeconds: 10);
            policy.Execute(() =>
            {
                try { element.Click(); }
                catch (WebDriverException ex)
                {
                    if (!knowErrorMessages.Any(x => x.Contains(ex.Message)))
                    {
                        Trace.WriteLine($"Unexpected WebDriverException was encountered: {ex.Message} {ex.StackTrace}");
                        return;
                    }
                }
            });
        }

        /// <summary>/
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

        public string GetAttribute(string attributeName)
        {
            var element = Driver.FindElementWithTimeSpan(ByForElement);
            return element.GetAttribute(attributeName);
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
            webElement = webElement ?? Driver.FindElement(ByForElement);

            try {
                JScrollSmooth(webElement); 
            }
            catch (Exception ex) { ActionsScrollToElement(webElement); }
        }


        // Used this type of sloppy loops to mimic scrolling with fingure.
        public void JScrollSmooth(IWebElement webElement = null)
        {
            webElement = webElement ?? Driver.FindElementWithTimeSpan(ByForElement);
            for (int i = 0; i < 10; i++) Driver.ExecuteScript("window.scrollBy(0, 1)", webElement);
            for (int i = 0; i < 10; i++) Driver.ExecuteScript("window.scrollBy(0, 2)", webElement);
            for (int i = 0; i < 30; i++) Driver.ExecuteScript("window.scrollBy(0, 30)", webElement);
            for (int i = 0; i < 7; i++) Driver.ExecuteScript("window.scrollBy(0, 3)", webElement);
            for (int i = 0; i < 5; i++) Driver.ExecuteScript("window.scrollBy(0, 1)", webElement);
            JScrollToElement(webElement);
            for (int i = 0; i < 10; i++) Driver.ExecuteScript("window.scrollBy(0, -2)", webElement);
            for (int i = 0; i < 5; i++) Driver.ExecuteScript("window.scrollBy(0, -5)", webElement);
        }

        public void JClickElement(IWebElement webElement = null)
        {
            Driver.ExecuteScript("argument[0]", webElement);
        }

        public void JScrollToElement(IWebElement webElement = null)
        {
            var jScript = "arguments[0].scrollIntoView(true);" +
            "var evObj = document.createEvent('MouseEvents');" +
            "evObj.initMouseEvent(\"mouseover\",true, false, window, 0, 0, 0, 0, 0, false, false, false, false, 0, null);" +
            "arguments[0].dispatchEvent(evObj);";

            webElement = webElement ?? Driver.FindElementWithTimeSpan(ByForElement);
            Driver.ExecuteScript(jScript, webElement);
        }

        private IWebElement GetScrollableElement(IWebElement element)
        {
            var numberOfTries = 10;
            IWebElement scrollableElement = null;
            // Using Polly library: https://github.com/App-vNext/Polly
            var policy = Policy
              .Handle<InvalidOperationException>()
              .WaitAndRetry(numberOfTries, timespan => TimeSpan.FromSeconds(15));

            policy.Execute(() =>
            {
                try
                {
                    var ancestors = element.FindElements(By.XPath("./ancestor-or-self::*")).Reverse();
                    scrollableElement = ancestors.FirstOrDefault(e => !e.Location.IsEmpty);
                }
                catch (StaleElementReferenceException ex)
                {
                    // ignore and try again
                }
            });

            return scrollableElement;
        }

        public void ActionsScrollToElement(IWebElement element)
        {
            var elementToScrollTo = GetScrollableElement(element);
            new Actions(Driver).MoveToElement(elementToScrollTo).Build().Perform();
        }

        public void ActionsDoubleClick(IWebElement element)
        {
            var elementToScrollTo = GetScrollableElement(element);
            new Actions(Driver).DoubleClick(elementToScrollTo).Perform();
        }

        public void ActionsRightClick(IWebElement element)
        {
            var elementToScrollTo = GetScrollableElement(element);
            new Actions(Driver).ContextClick(elementToScrollTo).Perform();
        }

        public void MoveCursorToElement(IWebElement element = null)
        {
            var action = new Actions(Driver);
            action.MoveToElement(Driver.FindElement(ByForElement)).Perform();
        }

        public void ActionsDragAndDrop(IWebElement srourceElement, IWebElement targetElement)
        {
            var action = new Actions(Driver);
            action.DragAndDrop(srourceElement, targetElement).Build().Perform();
        }

        private static IWebElement LocateScrollableElement(RemoteWebDriver driver, IWebElement firstElement)
        {
            var ancestors = firstElement.FindElements(By.XPath("./ancestor-or-self::*")).Reverse();
            var scrollableElement = ancestors.FirstOrDefault(element => !element.Location.IsEmpty);
            return scrollableElement;
        }


        public void FileUpload(string filePath)
        {
            // By setting the file detector, the SendKeys method will first upload the 
            // file from the local system to the remote machine on which the code is 
            // actually running. Then SendKeys will set the file in the<input> element, 
            // using the local file path on the remote machine.
            var fileDetectionDriver = Driver as IAllowsFileDetection;
            fileDetectionDriver.FileDetector = new LocalFileDetector();

            var elementToSendKeys = Driver.FindElementWithTimeSpan(ByForElement);

            if (elementToSendKeys.TagName != "input" || elementToSendKeys.GetAttribute("type") != "file") return;

            elementToSendKeys.SendKeys(filePath);
        }
    }
}
