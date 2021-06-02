using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;
using RuRayToolbox.Controls.TriggerControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="Recommended" />.
    /// </summary>
    public class Recommended : BaseEditor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Recommended"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        public Recommended(RemoteWebDriver driver) : base()
        {
        }

        /// <summary>
        /// Gets the ButtonEdit.
        /// </summary>
        public Button ButtonEdit => new Button(Driver, By.XPath("//span[text()='Recommended']/../..//table"));

        /// <summary>
        /// Gets the ButtonClose.
        /// </summary>
        public Button ButtonClose => new Button(Driver, By.XPath("//button[text()='Close']"));

        /// <summary>
        /// Gets the ButtonFacebookGetNotification.
        /// </summary>
        public RadioButton ButtonFacebookGetNotification => new RadioButton(Driver, By.XPath("//input[@id='u_e_1']"));

        /// <summary>
        /// Gets the ButtonFacebookDontGetNotifications.
        /// </summary>
        public RadioButton ButtonFacebookDontGetNotifications => new RadioButton(Driver, By.XPath("//input[@id='u_e_2']"));

        /// <summary>
        /// Gets the ButtonMessengerGetNotification.
        /// </summary>
        public RadioButton ButtonMessengerGetNotification => new RadioButton(Driver, By.XPath("//input[@id='u_e_3']"));

        /// <summary>
        /// Gets the ButtonMessengerDontGetNotifications.
        /// </summary>
        public RadioButton ButtonMessengerDontGetNotifications => new RadioButton(Driver, By.XPath("//input[@id='u_e_4']"));

        /// <summary>
        /// Gets the LabelDefaultEmail.
        /// </summary>
        public Label LabelDefaultEmail => new Label(Driver, By.XPath("//label[@for='u_e_5']//span[1]"));

        /// <summary>
        /// Gets the LinkAddEmailAddress.
        /// </summary>
        public Hyperlink<DialogAddEmailAddress> LinkAddEmailAddress =>
            new Hyperlink<DialogAddEmailAddress>(Driver, By.XPath($"//form[@id='u_e_7']//a[text()={ResMiscellaneous.AddEmailAddress}]"));

        /// <summary>
        /// Gets the ButtonSaveChanges.
        /// </summary>
        public Button ButtonSaveChanges => new Button(Driver, By.XPath("//form[@id='u_e_7']//input[@type='submit']"));

        /// <summary>
        /// The CheckboxGetEmailAlert.
        /// </summary>
        /// <param name="email">The email<see cref="string"/>.</param>
        /// <returns>The <see cref="Checkbox"/>.</returns>
        public Checkbox CheckboxGetEmailAlert(string email = null)
        {
            if (email == null)
            {
                email = LabelDefaultEmail.GetText();
            }

            return new Checkbox(Driver, By.XPath($"//input[@value='{email}']"));
        }

        /// <summary>
        /// The SetEmailsToGetAlert.
        /// </summary>
        /// <param name="emails">The emails<see cref="IEnumerable{(string, bool)}"/>.</param>
        public void SetEmailsToGetAlert(IEnumerable<(string, bool)> emails)
        {
            foreach (var email in emails)
            {
                CheckboxGetEmailAlert(email.Item1).SetCheckbox(email.Item2);
            }
        }

        /// <summary>
        /// The GetAllEmailsToGetAlert.
        /// </summary>
        public void GetAllEmailsToGetAlert()
        {
        }
    }

    /// <summary>
    /// Defines the <see cref="DialogAddEmailAddress" />.
    /// </summary>
    public class DialogAddEmailAddress : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogAddEmailAddress"/> class.
        /// </summary>
        public DialogAddEmailAddress()
        {
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath("//form[@id='u_y_1']");

        /// <summary>
        /// Gets the TextBoxNewEmail.
        /// </summary>
        public TextBox TextBoxNewEmail => new TextBox(Driver, By.XPath("//input[@name='new_email']"));

        /// <summary>
        /// Gets the ButtonDialogClose.
        /// </summary>
        public Button ButtonDialogClose => new Button(Driver, By.XPath("//form[@id='u_y_1']//a[@title='Close']"));

        /// <summary>
        /// Gets the ButtonCancel.
        /// </summary>
        public Button ButtonCancel => new Button(Driver, By.XPath($"//a[text()='{ResMiscellaneous.Cancel}']"));

        /// <summary>
        /// Gets the ButtonAdd.
        /// </summary>
        public Button ButtonAdd => new Button(Driver, By.XPath($"//form[@id='u_y_1']//button[text()={ResMiscellaneous.Add}]"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }

    /// <summary>
    /// Defines the <see cref="DialogConfirmYourEmail" />.
    /// </summary>
    public class DialogConfirmYourEmail : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogConfirmYourEmail"/> class.
        /// </summary>
        public DialogConfirmYourEmail()
        {
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath("//form[@action='/login_alerts/add/confirm/write/']");

        /// <summary>
        /// Gets the TextBoxConfirmEmailCode.
        /// </summary>
        public TextBox TextBoxConfirmEmailCode => new TextBox(Driver, By.XPath("//form[@action='/login_alerts/add/confirm/write/']//input[@placeholder]"));

        /// <summary>
        /// Gets the ButtonCancel.
        /// </summary>
        public Button ButtonCancel => new Button(Driver, By.XPath($"//form[@action='/login_alerts/add/confirm/write/']//a[text()={ResMiscellaneous.Cancel}]"));

        /// <summary>
        /// Gets the ButtonConfirm.
        /// </summary>
        public Button ButtonConfirm => new Button(Driver, By.XPath($"//form[@action='/login_alerts/add/confirm/write/']//button[text()={ResMiscellaneous.Confirm}]"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
