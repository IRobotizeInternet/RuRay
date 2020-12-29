using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Controls.TriggerControls;
using RobotizeToolbox.Dialogs;
using RobotizeFacebook.Resources;

namespace RobotizeFacebook.Pages.LoggedIn.Settings.Tabs.Seperator1
{
    public class AddAnotherEmailDialog : BaseDialog
    {
        public AddAnotherEmailDialog(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        protected override By ByForDialog => By.XPath("//div[@role='dialog' and @aria-labelledby='u_3_0']");

        public TextBox TextBoxEnterNewTextbox => new TextBox(Driver, By.XPath($"//input[@aria-label={ResMiscellaneous.EnterNewEmail}]"));
        public Button ButtonAdd => new Button(Driver, By.XPath("//button[text()='Add']"));
        public Button ButtonCancel => new Button(Driver, By.XPath($"//a[text()={ResMiscellaneous.Cancel}]"));
        public Hyperlink<AddPhoneNumberDialog> LinkAddYourPhoneNumber => 
            new Hyperlink<AddPhoneNumberDialog>(Driver, Wait, By.XPath($"//a[text()={ResMiscellaneous.AddYourPhoneNumber}]"));
    }

    public class AddPhoneNumberDialog : BaseDialog
    {
        public AddPhoneNumberDialog(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        protected override By ByForDialog => By.XPath("//div[@role='dialog' and @aria-labelledby='u_3_0']");

        public TextBox TextBoxEnterYourPhoneNumber => new TextBox(Driver, By.XPath("//input[@name='contact_point']"));
        public Dropdown DropdownSelectCountry => new Dropdown(Driver, By.XPath("//select[@id='country']"));
        public RadioButton ConfirmNumberBy => new RadioButton(Driver, By.XPath("//input[@name='verification_type']"));
        public Button ButtonContinue => new Button(Driver, By.XPath($"//button[text()={ResMiscellaneous.Continue}]"));
        public Button ButtonCancel => new Button(Driver, By.XPath($"//button[text()={ResMiscellaneous.Cancel}]"));
    }
}
