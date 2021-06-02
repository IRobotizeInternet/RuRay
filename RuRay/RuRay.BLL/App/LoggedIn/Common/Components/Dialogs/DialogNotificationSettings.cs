using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogNotificationSettings" />.
    /// </summary>
    public class DialogNotificationSettings : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogNotificationSettings"/> class.
        /// </summary>
        public DialogNotificationSettings()
        {
            BaseXPath = $"//div[@aria-label='{ResMiscellaneous.NotificationSettings}'][@role='dialog']";
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath(BaseXPath);

        /// <summary>
        /// Gets the ButtonSavedItems.
        /// </summary>
        public Button ButtonSavedItems => new Button(Driver, By.XPath($"//span[contains(text(),'{ResNotificationSettings.SavedItems}')]/../../../../../../..//div[@role='button']"));

        /// <summary>
        /// Gets the ButtonRecommendationsForYou.
        /// </summary>
        public Button ButtonRecommendationsForYou => new Button(Driver, By.XPath($"//span[contains(text(),'{ResNotificationSettings.RecommendationsForYou}')]/../../../../../../..//div[@role='button']"));

        /// <summary>
        /// Gets the ButtonSimilarItems.
        /// </summary>
        public Button ButtonSimilarItems => new Button(Driver, By.XPath($"//span[contains(text(),'{ResNotificationSettings.SimilarItems}')]/../../../../../../..//div[@role='button']"));

        /// <summary>
        /// Gets the ButtonBuyAndSellGroups.
        /// </summary>
        public Button ButtonBuyAndSellGroups => new Button(Driver, By.XPath($"//span[contains(text(),'{ResNotificationSettings.BuyAndSellGroups}')]/../../../../../../..//div[@role='button']"));

        /// <summary>
        /// Gets the ButtonListingStatus.
        /// </summary>
        public Button ButtonListingStatus => new Button(Driver, By.XPath($"//span[contains(text(),'{ResNotificationSettings.ListingStatus}')]/../../../../../../..//div[@role='button']"));

        /// <summary>
        /// Gets the ButtonFeaturedItems.
        /// </summary>
        public Button ButtonFeaturedItems => new Button(Driver, By.XPath($"//span[contains(text(),'{ResNotificationSettings.FeaturedItems}')]/../../../../../../..//div[@role='button']"));

        /// <summary>
        /// Gets the ButtonReducedPrices.
        /// </summary>
        public Button ButtonReducedPrices => new Button(Driver, By.XPath($"//span[contains(text(),'{ResNotificationSettings.ReducedPrices}')]/../../../../../../..//div[@role='button']"));

        /// <summary>
        /// Gets the ButtonMessageReminders.
        /// </summary>
        public Button ButtonMessageReminders => new Button(Driver, By.XPath($"//span[contains(text(),'{ResNotificationSettings.MessageReminders}')]/../../../../../../..//div[@role='button']"));

        /// <summary>
        /// Gets the ButtonDont.
        /// </summary>
        public Button ButtonDont => new Button(Driver, By.XPath($"//div[@aria-label='Notification Settings'][@role='dialog']//span[text()='{ResNotificationSettings.Done}']"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
