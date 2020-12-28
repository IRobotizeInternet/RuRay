using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Resources;
using RobotizeLibrary.CommonControls;
using RobotizeLibrary.Controls;
using RobotizeLibrary.Dialogs;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class DialogHelpUsImproveNewFacebook : BaseDialog
    {
        public DialogHelpUsImproveNewFacebook(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        private string _baseXPath = $"//div[@aria-label='{ResMiscellaneous.GiveFeedbackToFacebook}' and @role='dialog']//span[text()='{ResMiscellaneous.HelpUsImproveTheNewFacebook}']/../../../..";
        protected override By ByForDialog => By.XPath(_baseXPath);

        public Combobox ComboboxChooseAnArea => new Combobox(Driver, By.XPath($"{_baseXPath}//label[@aria-label='{ResMiscellaneous.ChooseAnArea}']"));
        public TextBox TextBoxChooseAnArea => new TextBox(Driver, By.XPath($"{_baseXPath}//textarea[@placeholder='{ResMiscellaneous.PleaseIncludeAsMuchInfoAsPossible}']"));
        public Button ButtonAddAScreenshotOrVideoRecommended => new Button(Driver, By.XPath($"{_baseXPath}//label[@span[text()='{ResMiscellaneous.AddAScreenshotOrVideoRecommended}']"));
        public Button ButtonCancel => new Button(Driver, By.XPath($"{_baseXPath}//label[@aria-label='{ResMiscellaneous.Cancel}']"));
        public Button ButtonSubmit => new Button(Driver, By.XPath($"{_baseXPath}//label[@aria-label='{ResMiscellaneous.Submit}']"));
    }
}
