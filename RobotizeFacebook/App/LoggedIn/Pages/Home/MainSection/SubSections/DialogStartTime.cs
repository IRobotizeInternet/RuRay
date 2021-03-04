using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogStartTime : BaseDialog
    {
        public DialogStartTime(RemoteWebDriver driver) : base(driver)
        {
        }

        protected override By ByForDialog =>
            By.XPath($"//div[@role='dialog']//div[@aria-label= '{ResMiscellaneous.ResetToNow}']");

        public EventTriggerButton<Calendar> EventTriggerTextboxDate =>
            new EventTriggerButton<Calendar>(Driver, By.XPath($"//div[@role='dialog']//label[@aria-label='{ResMiscellaneous.StartDate}']//input"));
        public EventTriggerButton<Calendar> EventTriggerTextboxTime =>
            new EventTriggerButton<Calendar>(Driver, By.XPath($"//div[@role='dialog']//label[@aria-label='{ResMiscellaneous.StartTime}']//input"));
        public Button ButtonResetToNow =>
            new Button(Driver, By.XPath($"//div[@role='dialog']//div[@aria-label='{ResMiscellaneous.ResetToNow}']"));
        public Button ButtonSave =>
            new Button(Driver, By.XPath($"//div[@role='dialog']//div[@aria-label='{ResLeftNav.Save}']"));


    }
}