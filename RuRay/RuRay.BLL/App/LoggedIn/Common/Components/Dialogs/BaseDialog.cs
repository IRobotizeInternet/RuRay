using System;
using System.Diagnostics;
using System.Linq;
using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Extensions;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="BaseDialog" />.
    /// </summary>
    public abstract class BaseDialog : BaseDriver
    {
        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected abstract By ByForDialog { get; }

        /// <summary>
        /// Defines the BaseXPath.
        /// </summary>
        protected string BaseXPath;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseDialog"/> class.
        /// </summary>
        protected BaseDialog()
        {
            if (ByForDialog != null)
            {
                WaitForDialogToAppear(ByForDialog);
            }
        }

        /// <summary>
        /// The WaitForDialogToAppear.
        /// </summary>
        /// <param name="byForDialog">The byForDialog<see cref="By"/>.</param>
        protected virtual void WaitForDialogToAppear(By byForDialog)
        {
            Driver.WaitUntilElementAppears(ByForDialog);
        }

        /// <summary>
        /// The WaitForDialogToDisappear.
        /// </summary>
        public virtual void WaitForDialogToDisappear()
        {
            Driver.WaitUntilElementDisappears(ByForDialog);
        }

        /// <summary>
        /// The DialogIsDisplayed.
        /// </summary>
        /// <param name="timeoutInSeconds">The timeoutInSeconds<see cref="int"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        protected bool DialogIsDisplayed(int timeoutInSeconds = 5)
        {
            try
            {
                var element = Driver.FindVisibleElementsWait(ByForDialog, timeoutInSeconds);
                if (element.Count() > 1)
                {
                    throw new Exception("Found more than one dialog for a give xPath.");
                }

                return true;
            }
            catch (WebDriverTimeoutException)
            {
                Debug.WriteLine("Web element was not found for a given period.");
                return false;
            }
        }

        /// <summary>
        /// The Close.
        /// </summary>
        /// <param name="xPath">The xPath<see cref="string"/>.</param>
        public void Close(string xPath = null)
        {
            Driver.FindElement(By.XPath(xPath ?? $"//div[@role='dialog']//div[@aria-label='{ResLeftNav.Close}']")).Click();
        }
    }
}
