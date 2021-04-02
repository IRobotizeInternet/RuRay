using OpenQA.Selenium;
using RobotizeFacebook.App.LoggedIn.Pages;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Controls.TriggerControls;

namespace RobotizeFacebook.App.NotLoggedIn
{
    public class DialogCreateNewAccount : BaseDialog
    {
        protected override By ByForDialog => throw new System.NotImplementedException();

        public DialogCreateNewAccount() { }

        public TextBox TextBoxFirstName => new TextBox(Driver, By.XPath("//input[@name='firstname']"));
        public TextBox TextBoxLastName => new TextBox(Driver, By.XPath("//input[@name='lastname']"));
        
        public TextBox TextBoxMobileNumberOrEmail => new TextBox(Driver, By.XPath("//input[@name='reg_email__']"));
        public TextBox TextBoxReMobileNumberOrEmail => new TextBox(Driver, By.XPath("//input[@name='reg_email_confirmation__']"));
        public TextBox TextBoxNewPassword => new TextBox(Driver, By.XPath("//input[@name='reg_passwd__']"));
        
        public Dropdown DropdownMonth => new Dropdown(Driver, By.XPath("//select[@name='birthday_month']"));
        public Dropdown DropdownDate => new Dropdown(Driver, By.XPath("//select[@name='birthday_day']"));
        public Dropdown DropdownYear => new Dropdown(Driver, By.XPath("//select[@name='birthday_year']"));

        public RadioButton RadioButtonFemale => new RadioButton(Driver, By.XPath("//input[@name='sex' and @value='1']"));
        public RadioButton RadioButtonMale => new RadioButton(Driver, By.XPath("//input[@name='sex' and @value='2']"));
        
        public RadioButton RadioButtonCustom => new RadioButton(Driver, By.XPath("//input[@name='sex' and @value='3']"));
        public Dropdown DropdownSelectYourPronoun => new Dropdown(Driver, By.XPath("//select[name='preferred_pronoun']"));
        public TextBox TextBoxGenderOptional => new TextBox(Driver, By.XPath("//input[@name='custom_gender']"));

        public Hyperlink<PageTerms> HyperlinkTerms => new Hyperlink<PageTerms>(Driver, By.XPath("//a[@id='terms-link']"));
        public Hyperlink<PagePrivacy> HyperlinkDataPolicy => new Hyperlink<PagePrivacy>(Driver, By.XPath("//a[@id='privacy-link']"));
        public Hyperlink<PageCookies> HyperlinkCookiePolicy => new Hyperlink<PageCookies>(Driver, By.XPath("//a[@id='cookie-use-link']"));

        public EventTriggerButton<PageHome> ButtonSignUp => new EventTriggerButton<PageHome>(Driver, By.XPath("//button[@name='websubmit')]"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
