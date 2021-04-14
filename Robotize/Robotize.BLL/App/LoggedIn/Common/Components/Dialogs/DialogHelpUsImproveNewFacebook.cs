using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogHelpUsImproveNewFacebook : BaseDialog
    {
        public DialogHelpUsImproveNewFacebook()
        {
            BaseXPath = $"//div[@aria-label='{ResMiscellaneous.GiveFeedbackToFacebook}' and @role='dialog']//span[text()='{ResMiscellaneous.HelpUsImproveTheNewFacebook}']/../../../..";
        }

        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResMiscellaneous.GiveFeedbackToFacebook}' and @role='dialog']//span[text()='{ResMiscellaneous.HelpUsImproveTheNewFacebook}']/../../../..");

        public ComboboxSharingWithYourFriends ComboboxChooseAnArea => new ComboboxSharingWithYourFriends(
            Driver,
            BaseXPath);
        public TextBox TextBoxChooseAnArea => new TextBox(Driver, By.XPath($"{BaseXPath}//textarea[@placeholder='{ResMiscellaneous.PleaseIncludeAsMuchInfoAsPossible}']"));
        public Button ButtonAddAScreenshotOrVideoRecommended => new Button(Driver, By.XPath($"{BaseXPath}//label[@span[text()='{ResMiscellaneous.AddAScreenshotOrVideoRecommended}']"));
        public Button ButtonCancel => new Button(Driver, By.XPath($"{BaseXPath}//label[@aria-label='{ResMiscellaneous.Cancel}']"));
        public Button ButtonSubmit => new Button(Driver, By.XPath($"{BaseXPath}//label[@aria-label='{ResMiscellaneous.Submit}']"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
