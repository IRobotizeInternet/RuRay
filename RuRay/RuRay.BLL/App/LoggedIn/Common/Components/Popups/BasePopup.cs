using System;
using System.Diagnostics;
using System.Linq;
using OpenQA.Selenium;
using RuRayToolbox.Extensions;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="BasePopup" />.
    /// </summary>
    public abstract class BasePopup : BaseDriver
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
        /// Initializes a new instance of the <see cref="BasePopup"/> class.
        /// </summary>
        protected BasePopup()
        {
            if (ByForDialog != null)
            {
                WaitForDialogToAppear();
            }
        }

        /// <summary>
        /// The WaitForDialogToAppear.
        /// </summary>
        protected virtual void WaitForDialogToAppear()
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
    }
}
