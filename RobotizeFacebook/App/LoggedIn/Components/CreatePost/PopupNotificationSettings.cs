using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class popupNotificationSettings : BaseDialog
    {
        public popupNotificationSettings(RemoteWebDriver driver) : base(driver)
        {
            BaseXPath = $"//div[@role='menu']//span[contains(text(), '{ResMiscellaneous.NotificationSettings}')]/../../../..";
        }

        protected override By ByForDialog => By.XPath(BaseXPath);

        public Button ButtonShowNotificationDots => new Button(Driver, By.XPath($"{BaseXPath}//div[@role='menuitemcheckbox']//span[contains(text(), '{ResMiscellaneous.ShowNotificationDots}')]"));
        public EventTriggerButton<DialogNotificationSettings> ButtonNotificationSetting =>
            new EventTriggerButton<DialogNotificationSettings>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResNotificationSettings.CustomizeNotifications}']"));
    }
}
