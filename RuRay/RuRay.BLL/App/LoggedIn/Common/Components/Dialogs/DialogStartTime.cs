using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class DialogStartTime : BaseDialog
    {
        public DialogStartTime()
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

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}