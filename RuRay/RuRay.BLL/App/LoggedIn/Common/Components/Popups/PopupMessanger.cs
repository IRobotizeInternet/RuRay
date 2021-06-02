using OpenQA.Selenium;
using RuRay.BLL.Resources;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="PopupMessanger" />.
    /// </summary>
    public class PopupMessanger : BaseDialog
    {
        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResHomePageHeader.Messenger}'][@role='dialog']");

        /// <summary>
        /// Initializes a new instance of the <see cref="PopupMessanger"/> class.
        /// </summary>
        public PopupMessanger()
        {
        }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
