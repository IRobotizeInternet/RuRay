using System;
using System.Diagnostics;
using System.Linq;
using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.Extensions;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public abstract class BaseDialog : BaseDriver
    {
        protected abstract By ByForDialog { get; }
        protected string BaseXPath;

        protected BaseDialog()
        {
            if (ByForDialog != null)  WaitForDialogToAppear(ByForDialog);
        }

        protected virtual void WaitForDialogToAppear(By byForDialog)
        {
            Driver.WaitUntilElementAppears(ByForDialog);
        }

        public virtual void WaitForDialogToDisappear()
        {
            Driver.WaitUntilElementDisappears(ByForDialog);
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

        public void Close(string xPath = null)
        {
            Driver.FindElement(By.XPath(xPath ?? $"//div[@role='dialog']//div[@aria-label='{ResLeftNav.Close}']")).Click();
        }
    }
}
