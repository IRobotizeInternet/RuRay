using System;
using System.Diagnostics;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using Polly;

namespace RuRayToolbox.Extensions
{
    /// <summary>
    /// Defines the <see cref="Acts" />.
    /// </summary>
    public static class Acts
    {
        // TODO:
        /// <summary>
        /// The ClickAndHold.
        /// </summary>
        public static void ClickAndHold()
        {
        }

        // TODO:
        /// <summary>
        /// The DrapAndDrop.
        /// </summary>
        public static void DrapAndDrop()
        {
        }

        /// <summary>
        /// The WaitForObjectToLoad.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <param name="waitThreshold">The waitThreshold<see cref="int"/>.</param>
        public static void WaitForObjectToLoad(RemoteWebDriver driver, int waitThreshold = 300)
        {
            var startTime = DateTime.Now;
            bool isObjectLoaded = false;
            while (isObjectLoaded)
            {
                try
                {
                    WaitForObjectToLoadForTimeSpan(driver);
                    isObjectLoaded = !isObjectLoaded;
                }
                catch (WebDriverTimeoutException)
                {
                    Debug.WriteLine($"{nameof(WebDriverTimeoutException)} occured while waiting to load the object");
                }

                if ((DateTime.Now - startTime).TotalSeconds >= waitThreshold)
                {
                    throw new Exception($"Object load timed out after: {waitThreshold}.");
                }
            }
        }

        /// <summary>
        /// This method will wait for DOM objects to load for 60 second timeout.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <param name="maxWaitTimeInSeconds">The maxWaitTimeInSeconds<see cref="double"/>.</param>
        public static void WaitForObjectToLoadForTimeSpan(RemoteWebDriver driver, double maxWaitTimeInSeconds = 60)
        {
            // Using Polly library: https://github.com/App-vNext/Polly
            var policy = Policy
              .Handle<InvalidOperationException>()
              .WaitAndRetry(10, timespan => TimeSpan.FromSeconds(maxWaitTimeInSeconds));

            policy.Execute(() =>
            {
                try
                {
                    // TODO: This is incorrect fix this 
                    var xPathLoadIndicitor = string.Empty;
                    if (!driver.FindElement(By.XPath(xPathLoadIndicitor)).Displayed)
                    {
                        return true;
                    }
                    else
                    {
                        Thread.Sleep(TimeSpan.FromMilliseconds(200));
                        return false;
                    }
                }
                catch (TimeoutException ex)
                {
                    Debug.WriteLine($"Timed our exception{ex.Message} \n {ex.InnerException}");
                    return false;
                }
            });
        }
    }
}
