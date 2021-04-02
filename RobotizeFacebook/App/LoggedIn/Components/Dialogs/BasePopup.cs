using OpenQA.Selenium;
using RobotizeToolbox.Extensions;
using System;
using System.Diagnostics;
using System.Linq;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public abstract class BasePopup : BaseDriver
    {
        protected abstract By ByForDialog { get; }
        protected string BaseXPath;

        protected BasePopup()
        {
            if (ByForDialog != null) WaitForDialogToAppear();
        }

        protected virtual void WaitForDialogToAppear()
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
    }
}
