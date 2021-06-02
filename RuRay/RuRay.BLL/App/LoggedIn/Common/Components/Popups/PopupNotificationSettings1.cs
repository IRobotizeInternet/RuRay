using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="PopupNotificationSettings1" />.
    /// </summary>
    public class PopupNotificationSettings1 : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PopupNotificationSettings1"/> class.
        /// </summary>
        public PopupNotificationSettings1()
        {
            BaseXPath = $"//div[@role='menu']//span[contains(text(), '{ResMiscellaneous.NotificationSettings}')]/../../../..";
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath(BaseXPath);

        /// <summary>
        /// Gets the ButtonShowNotificationDots.
        /// </summary>
        public Button ButtonShowNotificationDots => new Button(Driver, By.XPath($"{BaseXPath}//div[@role='menuitemcheckbox']//span[contains(text(), '{ResMiscellaneous.ShowNotificationDots}')]"));

        /// <summary>
        /// Gets the ButtonNotificationSetting.
        /// </summary>
        public EventTriggerButton<DialogNotificationSettings> ButtonNotificationSetting =>
            new EventTriggerButton<DialogNotificationSettings>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResNotificationSettings.CustomizeNotifications}']"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
