using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class PopupAccount : BasePopup
    {
        public PopupAccount(RemoteWebDriver driver) : base(driver)
        {
            BaseXPath = $"//div[@aria-label='{ResAccount.Account}'][@role='dialog']";
        }

        protected override By ByForDialog => By.XPath(BaseXPath);

        public EventTriggerButton<PageUserHome> TriggerSeeYourProfile => 
            new EventTriggerButton<PageUserHome>(Driver, By.XPath($"{BaseXPath}//a[@href='/me/']"));

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
    }
}
