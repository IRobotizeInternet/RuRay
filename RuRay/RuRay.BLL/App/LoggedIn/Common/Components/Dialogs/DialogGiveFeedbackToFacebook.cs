using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogGiveFeedbackToFacebook" />.
    /// </summary>
    public class DialogGiveFeedbackToFacebook : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogGiveFeedbackToFacebook"/> class.
        /// </summary>
        public DialogGiveFeedbackToFacebook()
        {
        }

        /// <summary>
        /// Gets the _baseXPath.
        /// </summary>
        private string _baseXPath => $"//div[@aria-label='{ResMiscellaneous.GiveFeedbackToFacebook}']";

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath(_baseXPath);

        /// <summary>
        /// Gets the DialogHelpToImproveTheNewFacebook.
        /// </summary>
        public EventTriggerButton<DialogHelpUsImproveNewFacebook> DialogHelpToImproveTheNewFacebook =>
            new EventTriggerButton<DialogHelpUsImproveNewFacebook>(Driver, By.XPath($"{_baseXPath}//span[text()='{ResMiscellaneous.HelpUsImproveTheNewFacebook}']"));

        /// <summary>
        /// Gets the DialogSomethingWentWrong.
        /// </summary>
        public EventTriggerButton<DialogHelpUsImproveNewFacebook> DialogSomethingWentWrong =>
            new EventTriggerButton<DialogHelpUsImproveNewFacebook>(Driver, By.XPath($"{_baseXPath}//span[text()='{ResMiscellaneous.SomethingWentWrong}']"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
