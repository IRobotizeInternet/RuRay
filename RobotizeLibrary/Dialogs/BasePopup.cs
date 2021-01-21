using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

using RobotizeToolbox.Extensions;
using System;
using System.Diagnostics;
using System.Linq;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace RobotizeToolbox.Dialogs
{
    public abstract class BasePopup
    {
        protected RemoteWebDriver Driver;
        protected abstract By ByForDialog { get; }
        protected string BaseXPath;

        protected BasePopup(RemoteWebDriver driver)
        {
            Driver = driver;
            if (ByForDialog != null) WaitForDialogToAppear();
        }

        protected virtual void WaitForDialogToAppear()
        {
            var wait = new WebDriverWait(Driver, new TimeSpan(0, 0, 30));
            wait.Until(ExpectedConditions.ElementIsVisible(ByForDialog));
        }

        public virtual void WaitForDialogToDisappear()
        {
            var wait = new WebDriverWait(Driver, new TimeSpan(0, 0, 30));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(ByForDialog));
        }

        protected bool DialogIsDisplayed(int timeoutInSeconds = 5)
        {
            try
            {
                var element = Driver.FindVisibleElementsWait(ByForDialog, timeoutInSeconds);
                if (element.Count() > 1) throw new Exception("Found more than one dialog for a give xPath.");

                return true;
            }
            catch (WebDriverTimeoutException)
            {
                Debug.WriteLine("Web element was not found for a given period.");
                return false;
            }
        }
    }
}
