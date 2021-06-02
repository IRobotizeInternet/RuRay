using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayFacebook.App.NotLoggedIn;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="PopupAccount" />.
    /// </summary>
    public class PopupAccount : BasePopup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PopupAccount"/> class.
        /// </summary>
        public PopupAccount()
        {
            BaseXPath = $"//div[@aria-label='{ResAccount.Account}'][@role='dialog']";
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResAccount.Account}'][@role='dialog']");

        /// <summary>
        /// Gets the TriggerSeeYourProfile.
        /// </summary>
        public EventTriggerButton<PageUserTimeline> TriggerSeeYourProfile =>
            new EventTriggerButton<PageUserTimeline>(Driver, By.XPath($"{BaseXPath}//a[@href='/me/']"));

        /// <summary>
        /// Gets the TriggerGiveFeedbackToFBDialog.
        /// </summary>
        public EventTriggerButton<DialogGiveFeedbackToFacebook> TriggerGiveFeedbackToFBDialog =>
            new EventTriggerButton<DialogGiveFeedbackToFacebook>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResAccount.GiveFeedback}']"));

        /// <summary>
        /// Gets the TriggerSettingAndPrivacyDialog.
        /// </summary>
        public EventTriggerButton<PopupSettingAndPrivacy> TriggerSettingAndPrivacyDialog =>
            new EventTriggerButton<PopupSettingAndPrivacy>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResAccount.SettingsAndPrivacy}']"));

        /// <summary>
        /// Gets the TriggerHelpAndSupportDialog.
        /// </summary>
        public EventTriggerButton<PopupHelpAndSupport> TriggerHelpAndSupportDialog =>
           new EventTriggerButton<PopupHelpAndSupport>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResAccount.HelpAndSupport}']"));

        /// <summary>
        /// Gets the TriggerDisplayAndAccessibilityDialog.
        /// </summary>
        public EventTriggerButton<PopupDisplayAndAccessibility> TriggerDisplayAndAccessibilityDialog =>
           new EventTriggerButton<PopupDisplayAndAccessibility>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResAccount.DisplayAndAccessibility}']"));

        /// <summary>
        /// Gets the TriggerLogOutPage.
        /// </summary>
        public EventTriggerButton<PageLogin> TriggerLogOutPage =>
           new EventTriggerButton<PageLogin>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResAccount.LogOut}']"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
