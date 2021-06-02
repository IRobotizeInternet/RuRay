using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="PopupSettingAndPrivacy" />.
    /// </summary>
    public class PopupSettingAndPrivacy : BasePopup
    {
        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath(string.Format(_xPathString, ResAccount.Account, ResAccount.Settings));

        /// <summary>
        /// Initializes a new instance of the <see cref="PopupSettingAndPrivacy"/> class.
        /// </summary>
        public PopupSettingAndPrivacy()
        {
            BaseXPath = $"//div[@aria-label='{ResAccount.Account}'][@role='dialog']";
        }

        /// <summary>
        /// Defines the _xPathString.
        /// </summary>
        private readonly string _xPathString = "//div[@aria-label='{0}'][@role='dialog']//span[text()='{1}']";

        /// <summary>
        /// Gets the ButtonSettings.
        /// </summary>
        public EventTriggerButton<PageSettings> ButtonSettings =>
            new EventTriggerButton<PageSettings>(Driver, By.XPath(string.Format(_xPathString, ResAccount.Account, ResAccount.Settings)));

        /// <summary>
        /// Gets the ButtonPrivacyCheckup.
        /// </summary>
        public EventTriggerButton<PagePrivacyCheckup> ButtonPrivacyCheckup =>
            new EventTriggerButton<PagePrivacyCheckup>(Driver, By.XPath(string.Format(_xPathString, ResAccount.Account, ResAccount.PrivacyCheckup)));

        /// <summary>
        /// Gets the ButtonPrivacyShortcuts.
        /// </summary>
        public EventTriggerButton<PagePrivacy> ButtonPrivacyShortcuts =>
            new EventTriggerButton<PagePrivacy>(Driver, By.XPath(string.Format(_xPathString, ResAccount.Account, ResAccount.PrivacyShortcuts)));

        /// <summary>
        /// Gets the ButtonActivityLog.
        /// </summary>
        public EventTriggerButton<PageActivityLog> ButtonActivityLog =>
            new EventTriggerButton<PageActivityLog>(Driver, By.XPath(string.Format(_xPathString, ResAccount.Account, ResAccount.ActivityLog)));

        /// <summary>
        /// Gets the ButtonNewsFeedPreferences.
        /// </summary>
        public EventTriggerButton<DialogNewsFeedPreferences> ButtonNewsFeedPreferences =>
            new EventTriggerButton<DialogNewsFeedPreferences>(Driver, By.XPath(string.Format(_xPathString, ResAccount.Account, ResAccount.NewsFeedPreferences)));

        // TODO: The click event needs to be adjusted to have an additional parameter, that selects tabs after loading the page.
        /// <summary>
        /// Gets the ButtonLanguage.
        /// </summary>
        public EventTriggerButton<PageSettings> ButtonLanguage =>
            new EventTriggerButton<PageSettings>(Driver, By.XPath(string.Format(_xPathString, ResAccount.Account, ResAccount.Language)));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
