using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Diagnostics;
using System.Linq;

namespace RobotizeLibrary.Extensions
{
    public static class RemoteWebDriverExts
    {
        /// <summary>
        /// Return the web element matching the selector.
        /// </summary>
        public static IWebElement FindElementWithTimeSpan(this RemoteWebDriver driver, By by, int timeSpanInSeconds = 30)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeSpanInSeconds));
            var elements = driver.FindElements(by);
            wait.Until(d =>
            {
                try
                {
                    elements = driver.FindElements(by);
                    return elements.Any();
                }
                catch (TimeoutException ex)
                {
                    Debug.WriteLine($"Timed our exception{ex.Message} \n {ex.InnerException}");
                    return false;
                }
            });

            // If no elements found then throw an exception.
            if (!elements.Any()) throw new NoSuchElementException($"No element found matching criteria '{by}'");

            // If found more than one element then throw an exception.
            if (elements.Count() > 1) throw new Exception($"More than one element found matching criteria '{by}'");

            return elements.First();
        }

        /// <summary>
        /// Return the web element matching the selector.
        /// </summary>
        public static IWebElement FindSingleElement(this RemoteWebDriver driver, By by)
        {
            var elements =  driver.FindElements(by);

            // If no elements found then throw an exception.
            if (!elements.Any()) throw new NoSuchElementException($"No element found matching criteria '{by}'");

            // If found more than one element then throw an exception.
            if (elements.Count() > 1) throw new Exception($"More than one element found matching criteria '{by}'");

            return elements.First();
        }

    }
}
