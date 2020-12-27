using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeLibrary.Controls.TriggerControls;
using RobotizeLibrary.Dialogs;
using RobotizeLibrary.Resources;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class PopupSettingAndPrivacy : BasePopup
    {
        protected override By ByForDialog => By.XPath(BaseXPath);

        public PopupSettingAndPrivacy(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
            BaseXPath = $"//div[@aria-label='{ResAccount.Account}'][@role='dialog']//span[text()='Settings']/../../../../../../../../../../..";
        }

        public EventTriggerButton<PageSettings> ButtonSettings => 
            new EventTriggerButton<PageSettings>(Driver, Wait, By.XPath($"{BaseXPath}//span[text()='{ResAccount.Settings}']"));
        
        public EventTriggerButton<PagePrivacyCheckup> ButtonPrivacyCheckup => 
            new EventTriggerButton<PagePrivacyCheckup>(Driver, Wait, By.XPath($"{BaseXPath}//span[text()='{ResAccount.PrivacyCheckup}']"));
        
        public EventTriggerButton<PagePrivacy> ButtonPrivacyShortcuts => 
            new EventTriggerButton<PagePrivacy>(Driver, Wait, By.XPath($"{BaseXPath}//span[text()='{ResAccount.PrivacyShortcuts}']"));
        
        public EventTriggerButton<PageActivityLog> ButtonActivityLog => 
            new EventTriggerButton<PageActivityLog>(Driver, Wait, By.XPath($"{BaseXPath}//span[text()='{ResAccount.ActivityLog}']"));
        
        public EventTriggerButton<DialogNewsFeedPreferences> ButtonNewsFeedPreferences => 
            new EventTriggerButton<DialogNewsFeedPreferences>(Driver, Wait, By.XPath($"{BaseXPath}//span[text()='{ResAccount.NewsFeedPreferences}']"));
        
        // TODO: The click event needs to be adjusted to have an additional parameter, that selects tabs after loading the page.
        public EventTriggerButton<PageSettings> ButtonLanguage => 
            new EventTriggerButton<PageSettings>(Driver, Wait, By.XPath($"{BaseXPath}//span[text()='{ResAccount.Language}']"));
    }
}
