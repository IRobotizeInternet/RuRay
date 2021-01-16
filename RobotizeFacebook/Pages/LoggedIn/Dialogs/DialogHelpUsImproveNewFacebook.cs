using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class DialogHelpUsImproveNewFacebook : BaseDialog
    {
        public DialogHelpUsImproveNewFacebook(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
            BaseXPath = $"//div[@aria-label='{ResMiscellaneous.GiveFeedbackToFacebook}' and @role='dialog']//span[text()='{ResMiscellaneous.HelpUsImproveTheNewFacebook}']/../../../..";
        }

        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResMiscellaneous.GiveFeedbackToFacebook}' and @role='dialog']//span[text()='{ResMiscellaneous.HelpUsImproveTheNewFacebook}']/../../../..");

        public SearchBoxSharingWithYourFriends ComboboxChooseAnArea => new SearchBoxSharingWithYourFriends(
            Driver, 
            By.XPath($"{BaseXPath}//label[@aria-label='{ResMiscellaneous.ChooseAnArea}']"), 
            BaseXPath);
        public TextBox TextBoxChooseAnArea => new TextBox(Driver, By.XPath($"{BaseXPath}//textarea[@placeholder='{ResMiscellaneous.PleaseIncludeAsMuchInfoAsPossible}']"));
        public Button ButtonAddAScreenshotOrVideoRecommended => new Button(Driver, By.XPath($"{BaseXPath}//label[@span[text()='{ResMiscellaneous.AddAScreenshotOrVideoRecommended}']"));
        public Button ButtonCancel => new Button(Driver, By.XPath($"{BaseXPath}//label[@aria-label='{ResMiscellaneous.Cancel}']"));
        public Button ButtonSubmit => new Button(Driver, By.XPath($"{BaseXPath}//label[@aria-label='{ResMiscellaneous.Submit}']"));
    }
}
