using System;
using OpenQA.Selenium;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="BaseSaveCancelDialog" />.
    /// </summary>
    public class BaseSaveCancelDialog : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseSaveCancelDialog"/> class.
        /// </summary>
        public BaseSaveCancelDialog()
        {
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => throw new NotImplementedException();

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
