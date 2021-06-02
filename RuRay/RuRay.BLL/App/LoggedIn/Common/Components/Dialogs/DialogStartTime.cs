using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogStartTime" />.
    /// </summary>
    public class DialogStartTime : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogStartTime"/> class.
        /// </summary>
        public DialogStartTime()
        {
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog =>
            By.XPath($"//div[@role='dialog']//div[@aria-label= '{ResMiscellaneous.ResetToNow}']");

        /// <summary>
        /// Gets the EventTriggerTextboxDate.
        /// </summary>
        public EventTriggerButton<Calendar> EventTriggerTextboxDate =>
            new EventTriggerButton<Calendar>(Driver, By.XPath($"//div[@role='dialog']//label[@aria-label='{ResMiscellaneous.StartDate}']//input"));

        /// <summary>
        /// Gets the EventTriggerTextboxTime.
        /// </summary>
        public EventTriggerButton<Calendar> EventTriggerTextboxTime =>
            new EventTriggerButton<Calendar>(Driver, By.XPath($"//div[@role='dialog']//label[@aria-label='{ResMiscellaneous.StartTime}']//input"));

        /// <summary>
        /// Gets the ButtonResetToNow.
        /// </summary>
        public Button ButtonResetToNow =>
            new Button(Driver, By.XPath($"//div[@role='dialog']//div[@aria-label='{ResMiscellaneous.ResetToNow}']"));

        /// <summary>
        /// Gets the ButtonSave.
        /// </summary>
        public Button ButtonSave =>
            new Button(Driver, By.XPath($"//div[@role='dialog']//div[@aria-label='{ResLeftNav.Save}']"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
