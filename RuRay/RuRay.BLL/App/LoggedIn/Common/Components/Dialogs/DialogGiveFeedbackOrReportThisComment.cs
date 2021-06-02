using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogGiveFeedbackOrReportThisComment" />.
    /// </summary>
    public class DialogGiveFeedbackOrReportThisComment : BaseDialog
    {
        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//span[text()='{ResHomePage.ReportCommentToAdmins}']");

        /// <summary>
        /// Initializes a new instance of the <see cref="DialogGiveFeedbackOrReportThisComment"/> class.
        /// </summary>
        public DialogGiveFeedbackOrReportThisComment()
        {
        }

        /// <summary>
        /// Gets the ButtonNudity.
        /// </summary>
        public Button ButtonNudity => new Button(Driver, By.XPath($"{ResHomePage.Nudity}"));

        /// <summary>
        /// Gets the ButtonVoilence.
        /// </summary>
        public Button ButtonVoilence => new Button(Driver, By.XPath($"{ResHomePage.Voilence}"));

        /// <summary>
        /// Gets the ButtonHarassment.
        /// </summary>
        public Button ButtonHarassment => new Button(Driver, By.XPath($"{ResHomePage.Harassment}"));

        /// <summary>
        /// Gets the ButtonSuicideOrSelfInjury.
        /// </summary>
        public Button ButtonSuicideOrSelfInjury => new Button(Driver, By.XPath($"{ResHomePage.SuicideOrSelfInjury}"));

        /// <summary>
        /// Gets the ButtonFalseInformation.
        /// </summary>
        public Button ButtonFalseInformation => new Button(Driver, By.XPath($"{ResHomePage.FalseInformation}"));

        /// <summary>
        /// Gets the ButtonSpam.
        /// </summary>
        public Button ButtonSpam => new Button(Driver, By.XPath($"{ResHomePage.Spam}"));

        /// <summary>
        /// Gets the ButtonUnauthorizedSales.
        /// </summary>
        public Button ButtonUnauthorizedSales => new Button(Driver, By.XPath($"{ResHomePage.UnauthorizedSales}"));

        /// <summary>
        /// Gets the ButtonHateSpeech.
        /// </summary>
        public Button ButtonHateSpeech => new Button(Driver, By.XPath($"{ResHomePage.HateSpeech}"));

        /// <summary>
        /// Gets the ButtonTerrorism.
        /// </summary>
        public Button ButtonTerrorism => new Button(Driver, By.XPath($"{ResHomePage.Terrorism}"));

        /// <summary>
        /// Gets the EventTriggerButtonSomethingElse.
        /// </summary>
        public EventTriggerButton<DialogSearhSomethingElse> EventTriggerButtonSomethingElse =>
            new EventTriggerButton<DialogSearhSomethingElse>(Driver, By.XPath($"{ResHomePage.SomethingElse}"));

        /// <summary>
        /// Gets the EventTriggerButtonNext.
        /// </summary>
        public EventTriggerButton<PageHome> EventTriggerButtonNext =>
            new EventTriggerButton<PageHome>(Driver, By.XPath($"{ResHomePage.Next}"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
