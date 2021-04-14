using OpenQA.Selenium;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Controls.TriggerControls;
using Robotize.BLL.Resources;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class AddAnotherEmailDialog : BaseDialog
    {
        public AddAnotherEmailDialog()
        {
        }

        protected override By ByForDialog => By.XPath("//div[@role='dialog' and @aria-labelledby='u_3_0']");

        public TextBox TextBoxEnterNewTextbox => new TextBox(Driver, By.XPath($"//input[@aria-label={ResMiscellaneous.EnterNewEmail}]"));
        public Button ButtonAdd => new Button(Driver, By.XPath("//button[text()='Add']"));
        public Button ButtonCancel => new Button(Driver, By.XPath($"//a[text()={ResMiscellaneous.Cancel}]"));
        public Hyperlink<AddPhoneNumberDialog> LinkAddYourPhoneNumber => 
            new Hyperlink<AddPhoneNumberDialog>(Driver, By.XPath($"//a[text()={ResMiscellaneous.AddYourPhoneNumber}]"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }

    public class AddPhoneNumberDialog : BaseDialog
    {
        public AddPhoneNumberDialog()
        {
        }

        protected override By ByForDialog => By.XPath("//div[@role='dialog' and @aria-labelledby='u_3_0']");

        public TextBox TextBoxEnterYourPhoneNumber => new TextBox(Driver, By.XPath("//input[@name='contact_point']"));
        public Dropdown DropdownSelectCountry => new Dropdown(Driver, By.XPath("//select[@id='country']"));
        public RadioButton ConfirmNumberBy => new RadioButton(Driver, By.XPath("//input[@name='verification_type']"));
        public Button ButtonContinue => new Button(Driver, By.XPath($"//button[text()={ResMiscellaneous.Continue}]"));
        public Button ButtonCancel => new Button(Driver, By.XPath($"//button[text()={ResMiscellaneous.Cancel}]"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
