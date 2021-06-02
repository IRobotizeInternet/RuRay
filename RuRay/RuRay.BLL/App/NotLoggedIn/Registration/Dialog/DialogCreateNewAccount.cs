using OpenQA.Selenium;
using RuRayFacebook.App.LoggedIn.Pages;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;
using RuRayToolbox.Controls.TriggerControls;

namespace RuRayFacebook.App.NotLoggedIn
{
    /// <summary>
    /// Defines the <see cref="DialogCreateNewAccount" />.
    /// </summary>
    public class DialogCreateNewAccount : BaseDialog
    {
        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => throw new System.NotImplementedException();

        /// <summary>
        /// Initializes a new instance of the <see cref="DialogCreateNewAccount"/> class.
        /// </summary>
        public DialogCreateNewAccount()
        {
        }

        /// <summary>
        /// Gets the TextBoxFirstName.
        /// </summary>
        public TextBox TextBoxFirstName => new TextBox(Driver, By.XPath("//input[@name='firstname']"));

        /// <summary>
        /// Gets the TextBoxLastName.
        /// </summary>
        public TextBox TextBoxLastName => new TextBox(Driver, By.XPath("//input[@name='lastname']"));

        /// <summary>
        /// Gets the TextBoxMobileNumberOrEmail.
        /// </summary>
        public TextBox TextBoxMobileNumberOrEmail => new TextBox(Driver, By.XPath("//input[@name='reg_email__']"));

        /// <summary>
        /// Gets the TextBoxReMobileNumberOrEmail.
        /// </summary>
        public TextBox TextBoxReMobileNumberOrEmail => new TextBox(Driver, By.XPath("//input[@name='reg_email_confirmation__']"));

        /// <summary>
        /// Gets the TextBoxNewPassword.
        /// </summary>
        public TextBox TextBoxNewPassword => new TextBox(Driver, By.XPath("//input[@name='reg_passwd__']"));

        /// <summary>
        /// Gets the DropdownMonth.
        /// </summary>
        public Dropdown DropdownMonth => new Dropdown(Driver, By.XPath("//select[@name='birthday_month']"));

        /// <summary>
        /// Gets the DropdownDate.
        /// </summary>
        public Dropdown DropdownDate => new Dropdown(Driver, By.XPath("//select[@name='birthday_day']"));

        /// <summary>
        /// Gets the DropdownYear.
        /// </summary>
        public Dropdown DropdownYear => new Dropdown(Driver, By.XPath("//select[@name='birthday_year']"));

        /// <summary>
        /// Gets the RadioButtonFemale.
        /// </summary>
        public RadioButton RadioButtonFemale => new RadioButton(Driver, By.XPath("//input[@name='sex' and @value='1']"));

        /// <summary>
        /// Gets the RadioButtonMale.
        /// </summary>
        public RadioButton RadioButtonMale => new RadioButton(Driver, By.XPath("//input[@name='sex' and @value='2']"));

        /// <summary>
        /// Gets the RadioButtonCustom.
        /// </summary>
        public RadioButton RadioButtonCustom => new RadioButton(Driver, By.XPath("//input[@name='sex' and @value='3']"));

        /// <summary>
        /// Gets the DropdownSelectYourPronoun.
        /// </summary>
        public Dropdown DropdownSelectYourPronoun => new Dropdown(Driver, By.XPath("//select[name='preferred_pronoun']"));

        /// <summary>
        /// Gets the TextBoxGenderOptional.
        /// </summary>
        public TextBox TextBoxGenderOptional => new TextBox(Driver, By.XPath("//input[@name='custom_gender']"));

        /// <summary>
        /// Gets the HyperlinkTerms.
        /// </summary>
        public Hyperlink<PageTerms> HyperlinkTerms => new Hyperlink<PageTerms>(Driver, By.XPath("//a[@id='terms-link']"));

        /// <summary>
        /// Gets the HyperlinkDataPolicy.
        /// </summary>
        public Hyperlink<PagePrivacy> HyperlinkDataPolicy => new Hyperlink<PagePrivacy>(Driver, By.XPath("//a[@id='privacy-link']"));

        /// <summary>
        /// Gets the HyperlinkCookiePolicy.
        /// </summary>
        public Hyperlink<PageCookies> HyperlinkCookiePolicy => new Hyperlink<PageCookies>(Driver, By.XPath("//a[@id='cookie-use-link']"));

        /// <summary>
        /// Gets the ButtonSignUp.
        /// </summary>
        public EventTriggerButton<PageHome> ButtonSignUp => new EventTriggerButton<PageHome>(Driver, By.XPath("//button[@name='websubmit')]"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
