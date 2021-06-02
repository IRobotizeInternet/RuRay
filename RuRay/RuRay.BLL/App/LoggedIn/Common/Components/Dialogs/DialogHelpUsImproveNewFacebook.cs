using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogHelpUsImproveNewFacebook" />.
    /// </summary>
    public class DialogHelpUsImproveNewFacebook : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogHelpUsImproveNewFacebook"/> class.
        /// </summary>
        public DialogHelpUsImproveNewFacebook()
        {
            BaseXPath = $"//div[@aria-label='{ResMiscellaneous.GiveFeedbackToFacebook}' and @role='dialog']//span[text()='{ResMiscellaneous.HelpUsImproveTheNewFacebook}']/../../../..";
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResMiscellaneous.GiveFeedbackToFacebook}' and @role='dialog']//span[text()='{ResMiscellaneous.HelpUsImproveTheNewFacebook}']/../../../..");

        /// <summary>
        /// Gets the ComboboxChooseAnArea.
        /// </summary>
        public ComboboxSharingWithYourFriends ComboboxChooseAnArea => new ComboboxSharingWithYourFriends(
            Driver,
            BaseXPath);

        /// <summary>
        /// Gets the TextBoxChooseAnArea.
        /// </summary>
        public TextBox TextBoxChooseAnArea => new TextBox(Driver, By.XPath($"{BaseXPath}//textarea[@placeholder='{ResMiscellaneous.PleaseIncludeAsMuchInfoAsPossible}']"));

        /// <summary>
        /// Gets the ButtonAddAScreenshotOrVideoRecommended.
        /// </summary>
        public Button ButtonAddAScreenshotOrVideoRecommended => new Button(Driver, By.XPath($"{BaseXPath}//label[@span[text()='{ResMiscellaneous.AddAScreenshotOrVideoRecommended}']"));

        /// <summary>
        /// Gets the ButtonCancel.
        /// </summary>
        public Button ButtonCancel => new Button(Driver, By.XPath($"{BaseXPath}//label[@aria-label='{ResMiscellaneous.Cancel}']"));

        /// <summary>
        /// Gets the ButtonSubmit.
        /// </summary>
        public Button ButtonSubmit => new Button(Driver, By.XPath($"{BaseXPath}//label[@aria-label='{ResMiscellaneous.Submit}']"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
