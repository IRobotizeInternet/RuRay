using System;
using System.Diagnostics;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeLibrary.CommonControls;
using RobotizeLibrary.Extensions;
using RobotizeLibrary.Resources;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace RobotizeLibrary.Dialogs
{
    public abstract class BaseDialog
    {
        protected RemoteWebDriver Driver;
        protected WebDriverWait Wait;
        protected abstract By ByForDialog { get; }

        protected BaseDialog(RemoteWebDriver driver, WebDriverWait wait)
        {
            Driver = driver;
            Wait = wait;
            if (ByForDialog != null)  WaitForDialogToAppear();
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

        // TODO: Set base path to uniquely idetify Close.
        public Button ButtonClose => new Button(Driver, By.XPath($"//div[@aria-label='{ResHomePageHeader.Close}']"));
    }
}
