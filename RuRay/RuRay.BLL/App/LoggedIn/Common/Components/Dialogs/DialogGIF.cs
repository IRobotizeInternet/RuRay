using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogGIF" />.
    /// </summary>
    public class DialogGIF : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogGIF"/> class.
        /// </summary>
        public DialogGIF()
        {
        }

        //public ScrollControl ScrollGIF =>
        //   new ScrollControl(Driver, $"//form[descendant::input[@aria-label='{ResCreatePost.GIFSearch}']]//img[@alt='GIF']");//form[@method='POST']/parent::div[@role='dialog']/form/div/div[2]/div/div[2]/div/div[2]/div/div/div"));
        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//form[@method='POST']/parent::div[@role='dialog']//span[text()='{ResCreatePost.ChooseAGIF}']");

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
                SearchBoxXPath = $"{BaseXPath}//input[contains(@aria-label,'{ResCreatePost.GIFSearch}')][@type='text']";
                SearchItemsXPath = $"{BaseXPath}//div[@aria-label='{ResCreatePost.GIF}']";
            }
        }
    }
}
