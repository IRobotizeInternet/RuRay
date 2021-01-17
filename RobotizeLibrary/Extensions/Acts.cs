using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

using System;
using System.Diagnostics;
using System.Threading;

namespace RobotizeToolbox.Extensions
{
    public static class Acts
    {

        // TODO:
        public static void ClickAndHold()
        {

        }

        // TODO:
        public static  void DrapAndDrop()
        {

        }

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
        /// This method will wait for DOM objects to load for 100 second timeout.
        /// </summary>
        public static void WaitForObjectToLoadForTimeSpan(RemoteWebDriver driver, double maxWaitTimeInSeconds = 60)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(maxWaitTimeInSeconds));
              _ = wait.Until(x =>
              {
                  try
                  {
                      var xPathLoadIndicitor = string.Empty;
                      if (!driver.FindElement(By.XPath(xPathLoadIndicitor)).Displayed) return true;
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
