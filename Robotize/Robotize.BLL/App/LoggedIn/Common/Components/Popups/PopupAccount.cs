using OpenQA.Selenium;
using RobotizeFacebook.App.NotLoggedIn;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PopupAccount : BasePopup
    {
        public PopupAccount()
        {
            BaseXPath = $"//div[@aria-label='{ResAccount.Account}'][@role='dialog']";
        }

        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResAccount.Account}'][@role='dialog']");

        public EventTriggerButton<PageUserTimeline> TriggerSeeYourProfile => 
            new EventTriggerButton<PageUserTimeline>(Driver, By.XPath($"{BaseXPath}//a[@href='/me/']"));

        public EventTriggerButton<DialogGiveFeedbackToFacebook> TriggerGiveFeedbackToFBDialog =>
            new EventTriggerButton<DialogGiveFeedbackToFacebook>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResAccount.GiveFeedback}']"));

        public EventTriggerButton<PopupSettingAndPrivacy> TriggerSettingAndPrivacyDialog => 
            new EventTriggerButton<PopupSettingAndPrivacy>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResAccount.SettingsAndPrivacy}']"));

        public EventTriggerButton<PopupHelpAndSupport> TriggerHelpAndSupportDialog =>
           new EventTriggerButton<PopupHelpAndSupport>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResAccount.HelpAndSupport}']"));

        public EventTriggerButton<PopupDisplayAndAccessibility> TriggerDisplayAndAccessibilityDialog =>
           new EventTriggerButton<PopupDisplayAndAccessibility>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResAccount.DisplayAndAccessibility}']"));

        public EventTriggerButton<PageLogin> TriggerLogOutPage =>
           new EventTriggerButton<PageLogin>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResAccount.LogOut}']"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
