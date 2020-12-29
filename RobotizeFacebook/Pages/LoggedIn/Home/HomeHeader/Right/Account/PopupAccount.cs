using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls.TriggerControls;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class PopupAccount : BasePopup
    {
        public PopupAccount(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
            BaseXPath = $"//div[@aria-label='{ResAccount.Account}'][@role='dialog']";
        }

        protected override By ByForDialog => By.XPath(BaseXPath);

        public EventTriggerButton<PageUserHome> TriggerSeeYourProfile => 
            new EventTriggerButton<PageUserHome>(Driver, Wait, By.XPath($"{BaseXPath}//a[@href='/me/']"));

        public EventTriggerButton<DialogGiveFeedbackToFacebook> TriggerGiveFeedbackToFBDialog =>
            new EventTriggerButton<DialogGiveFeedbackToFacebook>(Driver, Wait, By.XPath($"{BaseXPath}//span[text()='{ResAccount.GiveFeedback}']"));

        public EventTriggerButton<PopupSettingAndPrivacy> TriggerSettingAndPrivacyDialog => 
            new EventTriggerButton<PopupSettingAndPrivacy>(Driver, Wait, By.XPath($"{BaseXPath}//span[text()='{ResAccount.SettingsAndPrivacy}']"));

        public EventTriggerButton<PopupHelpAndSupport> TriggerHelpAndSupportDialog =>
           new EventTriggerButton<PopupHelpAndSupport>(Driver, Wait, By.XPath($"{BaseXPath}//span[text()='{ResAccount.HelpAndSupport}']"));

        public EventTriggerButton<PopupDisplayAndAccessibility> TriggerDisplayAndAccessibilityDialog =>
           new EventTriggerButton<PopupDisplayAndAccessibility>(Driver, Wait, By.XPath($"{BaseXPath}//span[text()='{ResAccount.DisplayAndAccessibility}']"));

        public EventTriggerButton<PageLogin> TriggerLogOutPage =>
           new EventTriggerButton<PageLogin>(Driver, Wait, By.XPath($"{BaseXPath}//span[text()='{ResAccount.LogOut}']"));
    }
}
