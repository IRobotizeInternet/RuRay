using System;
using System.Diagnostics;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using Polly;
using RuRayToolbox.Extensions;

namespace RuRayToolbox.CommonControls
{
    /// <summary>
    /// Defines the <see cref="BaseDOMObject" />.
    /// </summary>
    public class BaseDOMObject
    {
        /// <summary>
        /// Defines the ByForElement.
        /// </summary>
        protected By ByForElement;

        /// <summary>
        /// Defines the Driver.
        /// </summary>
        protected RemoteWebDriver Driver;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseDOMObject"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <param name="byForElement">The byForElement<see cref="By"/>.</param>
        public BaseDOMObject(RemoteWebDriver driver, By byForElement)
        {
            ByForElement = byForElement;
            Driver = driver;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseDOMObject"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        public BaseDOMObject(RemoteWebDriver driver)
        {
            Driver = driver;
        }

        /// <summary>
        /// Gets a value indicating whether IsDOMObjectExist
        /// Check whether or not the element exists..
        /// </summary>
        public bool IsDOMObjectExist => Driver.TryFindElement(ByForElement, out _);

        /// <summary>
        /// This method will try to click on the element atleast three times.
        /// Known issue <see cref="https://stackoverflow.com/questions/11908249/debugging-element-is-not-clickable-at-point-error?page=1&tab=votes#tab-top"/>.
        /// </summary>
        /// <param name="numberOfTries">The numberOfTries<see cref="int"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public virtual bool Click(int numberOfTries = 3)
        {
            // Using Polly library: https://github.com/App-vNext/Polly
            var policy = Policy
              .Handle<InvalidOperationException>()
              .Or<WebDriverException>()
              .Or<ElementClickInterceptedException>() /* This could happen when element under other element ex: Behind dialog window*/
              .WaitAndRetry(numberOfTries, timespan => TimeSpan.FromSeconds(3));

            policy.Execute(() =>
            {
                try
                {
                    var element = Driver.FindElementWithTimeSpan(ByForElement, timeSpanInSeconds: 3);
                    element?.Click();
                }
                catch (ElementClickInterceptedException ex)
                {
                    // Catching this exclusively, although it is added to the policy 
                    // we found some cases where it is still managing to break the execution.
                    // So we added this to handle it gracefully.
                    Debug.WriteLine(ex.Message);
                }
            });

            return true;
        }

        /// <summary>
        /// Clear value.
        /// Select All + Backspace.
        /// </summary>
        public void Clear()
        {
            var elementToClear = Driver.FindElementWithTimeSpan(ByForElement);
            elementToClear.SendKeys(Keys.Control + "a");
            elementToClear.SendKeys(Keys.Backspace);
            elementToClear.Clear();
        }

        /// <summary>
        /// The GetAttribute.
        /// </summary>
        /// <param name="attributeName">The attributeName<see cref="string"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public string GetAttribute(string attributeName)
        {
            var element = Driver.FindElementWithTimeSpan(ByForElement);
            return element.GetAttribute(attributeName);
        }

        /// <summary>
        /// Set value into an elements like a textbox for textarea. It also takes a 
        /// boolean flag to replace or append to the current value.
        /// </summary>
        /// <param name="valueToEnter">The valueToEnter<see cref="string"/>.</param>
        /// <param name="overwrite">The overwrite<see cref="bool"/>.</param>
        public void SetData(string valueToEnter, bool overwrite = true)
        {
            var startTime = DateTime.Now;
            var timeSpanInSeconds = 5;
            var finishedSettingValue = true;
            while (finishedSettingValue)
            {
                try
                {
                    var elementToSendKeys = Driver.FindElementWithTimeSpan(ByForElement);

                    if (overwrite)
                    {
                        Clear();
                    }

                    elementToSendKeys.SendKeys(valueToEnter);
                    finishedSettingValue = !finishedSettingValue;
                }
                catch (InvalidElementStateException ex)
                {
                    throw new Exception($"Invalid element state exception occured: {ex.Message} {ex.StackTrace}");
                }

                // Throw when time span finished when setting up the value. 
                var timeElapsed = (DateTime.Now - startTime).TotalSeconds;
                if (timeElapsed >= timeSpanInSeconds)
                {
                    throw new TimeoutException($"Time out exception occured after: {timeSpanInSeconds} seconds.");
                }
            }
        }

        /// <summary>
        /// Gets text property of an element.
        /// </summary>
        /// <returns>The <see cref="string"/>.</returns>
        public string GetText()
        {
            var gettingElementText = true;
            var totalAttempts = 3;
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

        /// <summary>
        /// The ScrollToElement.
        /// </summary>
        /// <param name="xPathTargetElement">The xPathTargetElement<see cref="string"/>.</param>
        /// <param name="scrollUp">The scrollUp<see cref="bool"/>.</param>
        protected void ScrollToElement(
            string xPathTargetElement,
            bool scrollUp = true)
        {
            try
            {
                if (scrollUp)
                {
                    JScrollSmoothUp(xPathTargetElement);
                }
                else
                {
                    JScrollSmoothDown(xPathTargetElement);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                ScrollToElement(xPathTargetElement);
            }
        }

        /// <summary>
        /// The JScrollSmoothUp.
        /// </summary>
        /// <param name="xPathDestElement">The xPathDestElement<see cref="string"/>.</param>
        protected void JScrollSmoothUp(
            string xPathDestElement)
        {
            var destWebElement = Driver.FindElementWithTimeSpan(By.XPath(xPathDestElement));
            var currentLocation = ((RemoteWebElement)destWebElement).LocationOnScreenOnceScrolledIntoView;
            var previousLocation = currentLocation;
            // Slowly scroll to mimic manual scrolling. 
            for (var i = 1; currentLocation.Y >= 100; i += 80 /*100 & 80 is an offset I came up after trying different combinations*/)
            {
                for (var j = 0; j < 8; j++)
                {
                    JscriptExecutor.ScrollBy(Driver, null, scrollingLengthYAxis: j * 2);
                }

                for (var j = 8; j > 0; j--)
                {
                    JscriptExecutor.ScrollBy(Driver, null, scrollingLengthYAxis: j * 2);
                }

                destWebElement = Driver.FindElementWithTimeSpan(By.XPath(xPathDestElement));
                currentLocation = ((RemoteWebElement)destWebElement).LocationOnScreenOnceScrolledIntoView;

                // Please note, this check is added to ensure when we scroll the element and 
                // new location is same as previous location, it is an indicator that the element
                // we are trying to scroll is hidden by other element and did not move when using
                // ScrollBy function. To avoid being stuck in the the infinite loop, we added this 
                // this check. 
                if (previousLocation == currentLocation)
                {
                    break;
                }
            }

            // Adding this offset to give more natural scrolling effect. 
            for (int i = 0; i < 10; i++)
            {
                ScrollMore(null, scrollingLengthYAxis: 5, scrollDown: 1);
            }
        }

        /// <summary>
        /// The JScrollSmoothDown.
        /// </summary>
        /// <param name="xPathDestElement">The xPathDestElement<see cref="string"/>.</param>
        protected void JScrollSmoothDown(
            string xPathDestElement)
        {
            var destWebElement = Driver.FindElementWithTimeSpan(By.XPath(xPathDestElement));
            var currentLocation = ((RemoteWebElement)destWebElement).LocationOnScreenOnceScrolledIntoView;

            var previousLocation = currentLocation;
            // Slowly scroll to mimic manual scrolling. 
            for (var i = 1; currentLocation.Y < 100; i += 80 /*80 is an offset I came up after trying different combinations*/)
            {
                for (var j = 0; j < 8; j++)
                {
                    JscriptExecutor.ScrollBy(Driver, null, scrollingLengthYAxis: j * -2);
                }

                for (var j = 8; j > 0; j--)
                {
                    JscriptExecutor.ScrollBy(Driver, null, scrollingLengthYAxis: j * -2);
                }

                destWebElement = Driver.FindElementWithTimeSpan(By.XPath(xPathDestElement));
                currentLocation = ((RemoteWebElement)destWebElement).LocationOnScreenOnceScrolledIntoView;

                // Please note, this check is added to ensure when we scroll the element and 
                // new location is same as previous location, it is an indicator that the element
                // we are trying to scroll is hidden by other element and did not move when using
                // ScrollBy function. To avoid being stuck in the the infinite loop, we added this 
                // this check. 
                if (previousLocation == currentLocation)
                {
                    break;
                }
            }

            // Adding this offset to give more natural scrolling effect. 
            for (int i = 0; i < 10; i++)
            {
                ScrollMore(null, scrollingLengthYAxis: 5);
            }
        }

        /// <summary>
        /// Use this method to scroll up/down for a give hieght.
        /// </summary>
        /// <param name="elementXPath">The elementXPath<see cref="string"/>.</param>
        /// <param name="scrollingLengthXAxis">The scrollingLengthXAxis<see cref="double"/>.</param>
        /// <param name="scrollingLengthYAxis">The scrollingLengthYAxis<see cref="double"/>.</param>
        /// <param name="scrollDown"> -1 scrolling down and 1 for scrolling up.</param>
        protected void ScrollMore(
            string elementXPath,
            double scrollingLengthXAxis = 0,
            double scrollingLengthYAxis = 10,
            int scrollDown = -1)
        {
            JscriptExecutor.ScrollBy(
                Driver,
                elementXPath,
                scrollDown * scrollingLengthXAxis * 2 /*Adding some random offset*/,
                scrollDown * scrollingLengthYAxis * 2 /*Adding some random offset*/);
        }

        /// <summary>
        /// The JClickElement.
        /// </summary>
        /// <param name="webElement">The webElement<see cref="IWebElement"/>.</param>
        protected void JClickElement(IWebElement webElement = null)
        {
            Driver.ExecuteScript("argument[0]", webElement);
        }

        /// <summary>
        /// The GetScrollableElement.
        /// </summary>
        /// <param name="element">The element<see cref="IWebElement"/>.</param>
        /// <returns>The <see cref="IWebElement"/>.</returns>
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
                    Debug.WriteLine(ex.Message);
                    // ignore and try again
                }
            });

            return scrollableElement;
        }

        /// <summary>
        /// The ScrollToElement.
        /// </summary>
        /// <param name="element">The element<see cref="IWebElement"/>.</param>
        public void ScrollToElement(IWebElement element)
        {
            var elementToScrollTo = GetScrollableElement(element);
            new Actions(Driver).MoveToElement(elementToScrollTo).Build().Perform();
        }

        /// <summary>
        /// The ActionsDoubleClick.
        /// </summary>
        /// <param name="element">The element<see cref="IWebElement"/>.</param>
        public void ActionsDoubleClick(IWebElement element)
        {
            var elementToScrollTo = GetScrollableElement(element);
            new Actions(Driver).DoubleClick(elementToScrollTo).Perform();
        }

        /// <summary>
        /// The ActionsRightClick.
        /// </summary>
        /// <param name="element">The element<see cref="IWebElement"/>.</param>
        public void ActionsRightClick(IWebElement element)
        {
            var elementToScrollTo = GetScrollableElement(element);
            new Actions(Driver).ContextClick(elementToScrollTo).Perform();
        }

        /// <summary>
        /// Clicking on the element twice will require the cursor to be moved frist, before 
        ///  we act on the same element; otherwise, it will throwup.
        /// </summary>
        /// <param name="element"> Web element.</param>
        public void MoveCursorToElement(IWebElement element = null)
        {
            var action = new Actions(Driver);
            if (Driver.TryFindElement(ByForElement, out var ele) && !ele.Location.IsEmpty)
            {
                action.MoveToElement(ele).Perform();
            }
        }

        /// <summary>
        /// The ActionsDragAndDrop.
        /// </summary>
        /// <param name="srourceElement">The srourceElement<see cref="IWebElement"/>.</param>
        /// <param name="targetElement">The targetElement<see cref="IWebElement"/>.</param>
        public void ActionsDragAndDrop(IWebElement srourceElement, IWebElement targetElement)
        {
            var action = new Actions(Driver);
            action.DragAndDrop(srourceElement, targetElement).Build().Perform();
        }

        /// <summary>
        /// The LocateScrollableElement.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <param name="firstElement">The firstElement<see cref="IWebElement"/>.</param>
        /// <returns>The <see cref="IWebElement"/>.</returns>
        private static IWebElement LocateScrollableElement(RemoteWebDriver driver, IWebElement firstElement)
        {
            var ancestors = firstElement.FindElements(By.XPath("./ancestor-or-self::*")).Reverse();
            var scrollableElement = ancestors.FirstOrDefault(element => !element.Location.IsEmpty);
            return scrollableElement;
        }

        /// <summary>
        /// By setting the file detector, the SendKeys method will first upload the 
        /// file from the local system to the remote machine on which the code is 
        /// actually running. Then SendKeys will set the file in the<input> element, 
        /// using the local file path on the remote machine.
        /// </summary>
        /// <param name="filePath">The filePath<see cref="string"/>.</param>
        public void FileUpload(string filePath)
        {
            var fileDetectionDriver = Driver as IAllowsFileDetection;
            fileDetectionDriver.FileDetector = new LocalFileDetector();

            var elementToSendKeys = Driver.FindElementWithTimeSpan(ByForElement);

            if (elementToSendKeys.TagName != "input" || elementToSendKeys.GetAttribute("type") != "file")
            {
                return;
            }

            elementToSendKeys.SendKeys(filePath);
        }
    }
}
