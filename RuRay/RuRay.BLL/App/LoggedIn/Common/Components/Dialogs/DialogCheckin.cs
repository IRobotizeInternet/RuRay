using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogCheckin" />.
    /// </summary>
    public class DialogCheckin : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogCheckin"/> class.
        /// </summary>
        public DialogCheckin()
        {
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//form[@method='POST']/parent::div[@role='dialog']//span[text()='{ResCreatePost.SearchForLocation}']");

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Defines the <see cref="CheckinCombox" />.
        /// </summary>
        public sealed class CheckinCombox : Combobox
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="CheckinCombox"/> class.
            /// </summary>
            /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
            /// <param name="byForElement">The byForElement<see cref="By"/>.</param>
            public CheckinCombox(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
            {
                BaseXPath = $"//form[@method='POST']/parent::div[@role='dialog']";
                SearchBoxXPath = $"{BaseXPath}//input[contains(@aria-label,'{ResCreatePost.WhereAreYou}')][@type='search']";
                SearchItemsXPath = $"{BaseXPath}//ul[@role='listbox']";
            }
        }
    }
}
