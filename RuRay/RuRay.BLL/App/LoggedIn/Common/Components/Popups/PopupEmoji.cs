using OpenQA.Selenium;
using RuRay.BLL.Resources;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="PopupEmoji" />.
    /// </summary>
    public class PopupEmoji : BasePopup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PopupEmoji"/> class.
        /// </summary>
        public PopupEmoji()
        {
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@role='dialog']//h3[text()='{ResCreatePost.RecentlyUsed}']");

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
