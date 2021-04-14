using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PopupNotificationSettings1 : BaseDialog
    {
        public PopupNotificationSettings1()
        {
            BaseXPath = $"//div[@role='menu']//span[contains(text(), '{ResMiscellaneous.NotificationSettings}')]/../../../..";
        }

        protected override By ByForDialog => By.XPath(BaseXPath);

        public Button ButtonShowNotificationDots => new Button(Driver, By.XPath($"{BaseXPath}//div[@role='menuitemcheckbox']//span[contains(text(), '{ResMiscellaneous.ShowNotificationDots}')]"));
        public EventTriggerButton<DialogNotificationSettings> ButtonNotificationSetting =>
            new EventTriggerButton<DialogNotificationSettings>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResNotificationSettings.CustomizeNotifications}']"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
