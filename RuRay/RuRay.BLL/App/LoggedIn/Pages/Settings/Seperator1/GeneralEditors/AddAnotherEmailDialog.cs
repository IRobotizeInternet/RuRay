using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;
using RuRayToolbox.Controls.TriggerControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="AddAnotherEmailDialog" />.
    /// </summary>
    public class AddAnotherEmailDialog : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddAnotherEmailDialog"/> class.
        /// </summary>
        public AddAnotherEmailDialog()
        {
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath("//div[@role='dialog' and @aria-labelledby='u_3_0']");

        /// <summary>
        /// Gets the TextBoxEnterNewTextbox.
        /// </summary>
        public TextBox TextBoxEnterNewTextbox => new TextBox(Driver, By.XPath($"//input[@aria-label={ResMiscellaneous.EnterNewEmail}]"));

        /// <summary>
        /// Gets the ButtonAdd.
        /// </summary>
        public Button ButtonAdd => new Button(Driver, By.XPath("//button[text()='Add']"));

        /// <summary>
        /// Gets the ButtonCancel.
        /// </summary>
        public Button ButtonCancel => new Button(Driver, By.XPath($"//a[text()={ResMiscellaneous.Cancel}]"));

        /// <summary>
        /// Gets the LinkAddYourPhoneNumber.
        /// </summary>
        public Hyperlink<AddPhoneNumberDialog> LinkAddYourPhoneNumber =>
            new Hyperlink<AddPhoneNumberDialog>(Driver, By.XPath($"//a[text()={ResMiscellaneous.AddYourPhoneNumber}]"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }

    /// <summary>
    /// Defines the <see cref="AddPhoneNumberDialog" />.
    /// </summary>
    public class AddPhoneNumberDialog : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddPhoneNumberDialog"/> class.
        /// </summary>
        public AddPhoneNumberDialog()
        {
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath("//div[@role='dialog' and @aria-labelledby='u_3_0']");

        /// <summary>
        /// Gets the TextBoxEnterYourPhoneNumber.
        /// </summary>
        public TextBox TextBoxEnterYourPhoneNumber => new TextBox(Driver, By.XPath("//input[@name='contact_point']"));

        /// <summary>
        /// Gets the DropdownSelectCountry.
        /// </summary>
        public Dropdown DropdownSelectCountry => new Dropdown(Driver, By.XPath("//select[@id='country']"));

        /// <summary>
        /// Gets the ConfirmNumberBy.
        /// </summary>
        public RadioButton ConfirmNumberBy => new RadioButton(Driver, By.XPath("//input[@name='verification_type']"));

        /// <summary>
        /// Gets the ButtonContinue.
        /// </summary>
        public Button ButtonContinue => new Button(Driver, By.XPath($"//button[text()={ResMiscellaneous.Continue}]"));

        /// <summary>
        /// Gets the ButtonCancel.
        /// </summary>
        public Button ButtonCancel => new Button(Driver, By.XPath($"//button[text()={ResMiscellaneous.Cancel}]"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
