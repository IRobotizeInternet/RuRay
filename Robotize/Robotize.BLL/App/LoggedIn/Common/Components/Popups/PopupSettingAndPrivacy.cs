using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PopupSettingAndPrivacy : BasePopup
    {
        protected override By ByForDialog => By.XPath(string.Format(_xPathString, ResAccount.Account, ResAccount.Settings));

        public PopupSettingAndPrivacy()
        {
            BaseXPath = $"//div[@aria-label='{ResAccount.Account}'][@role='dialog']";
        }

        private readonly string _xPathString = "//div[@aria-label='{0}'][@role='dialog']//span[text()='{1}']";

        public EventTriggerButton<PageSettings> ButtonSettings => 
            new EventTriggerButton<PageSettings>(Driver, By.XPath(string.Format(_xPathString, ResAccount.Account, ResAccount.Settings)));
        
        public EventTriggerButton<PagePrivacyCheckup> ButtonPrivacyCheckup => 
            new EventTriggerButton<PagePrivacyCheckup>(Driver, By.XPath(string.Format(_xPathString, ResAccount.Account, ResAccount.PrivacyCheckup)));
        
        public EventTriggerButton<PagePrivacy> ButtonPrivacyShortcuts => 
            new EventTriggerButton<PagePrivacy>(Driver, By.XPath(string.Format(_xPathString, ResAccount.Account, ResAccount.PrivacyShortcuts)));
        
        public EventTriggerButton<PageActivityLog> ButtonActivityLog => 
            new EventTriggerButton<PageActivityLog>(Driver, By.XPath(string.Format(_xPathString, ResAccount.Account, ResAccount.ActivityLog)));
        
        public EventTriggerButton<DialogNewsFeedPreferences> ButtonNewsFeedPreferences => 
            new EventTriggerButton<DialogNewsFeedPreferences>(Driver, By.XPath(string.Format(_xPathString, ResAccount.Account, ResAccount.NewsFeedPreferences)));
        
        // TODO: The click event needs to be adjusted to have an additional parameter, that selects tabs after loading the page.
        public EventTriggerButton<PageSettings> ButtonLanguage => 
            new EventTriggerButton<PageSettings>(Driver, By.XPath(string.Format(_xPathString, ResAccount.Account, ResAccount.Language)));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
