using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeLibrary.CommonControls;
using RobotizeLibrary.Controls;
using RobotizeLibrary.Controls.TriggerControls;
using RobotizeLibrary.Dialogs;
using RobotizeLibrary.Resources;
using System.Collections.Generic;

namespace RobotizeFacebook.Pages.LoggedIn.Settings.Tabs.Seperator1
{
    public class Recommended : BaseEditor
    {
        public Recommended(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public Button ButtonEdit => new Button(Driver, By.XPath("//span[text()='Recommended']/../..//table"));
        public Button ButtonClose => new Button(Driver, By.XPath("//button[text()='Close']"));
        public RadioButton ButtonFacebookGetNotification => new RadioButton(Driver, By.XPath("//input[@id='u_e_1']"));
        public RadioButton ButtonFacebookDontGetNotifications => new RadioButton(Driver, By.XPath("//input[@id='u_e_2']"));
        public RadioButton ButtonMessengerGetNotification => new RadioButton(Driver, By.XPath("//input[@id='u_e_3']"));
        public RadioButton ButtonMessengerDontGetNotifications => new RadioButton(Driver, By.XPath("//input[@id='u_e_4']"));
        public Label LabelDefaultEmail => new Label(Driver, By.XPath("//label[@for='u_e_5']//span[1]"));
        public Hyperlink<DialogAddEmailAddress> LinkAddEmailAddress => 
            new Hyperlink<DialogAddEmailAddress>(Driver, Wait, By.XPath($"//form[@id='u_e_7']//a[text()={ResMiscellaneous.AddEmailAddress}]"));
        public Button ButtonSaveChanges => new Button(Driver, By.XPath("//form[@id='u_e_7']//input[@type='submit']"));
        public Checkbox CheckboxGetEmailAlert(string email = null)
        {
            if (email == null) email = LabelDefaultEmail.GetText();
            return new Checkbox(Driver, By.XPath($"//input[@value='{email}']"));
        }

        public void SetEmailsToGetAlert(IEnumerable<(string, bool)> emails)
        {
            foreach(var email in emails) CheckboxGetEmailAlert(email.Item1).SetCheckbox(email.Item2);
        }

        public void GetAllEmailsToGetAlert()
        {
            
        }

    }

    public class DialogAddEmailAddress : DialogBase
    {
        public DialogAddEmailAddress(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        protected override By ByForDialog => By.XPath("//form[@id='u_y_1']");

        public TextBox TextBoxNewEmail => new TextBox(Driver, By.XPath("//input[@name='new_email']"));
        public Button ButtonDialogClose => new Button(Driver, By.XPath("//form[@id='u_y_1']//a[@title='Close']"));
        public Button ButtonCancel => new Button(Driver, By.XPath($"//a[text()='{ResMiscellaneous.Cancel}']"));
        public Button ButtonAdd => new Button(Driver, By.XPath($"//form[@id='u_y_1']//button[text()={ResMiscellaneous.Add}]"));
    }

    public class DialogConfirmYourEmail : DialogBase
    {
        public DialogConfirmYourEmail(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        protected override By ByForDialog => By.XPath("//form[@action='/login_alerts/add/confirm/write/']");
        public TextBox TextBoxConfirmEmailCode => new TextBox(Driver, By.XPath("//form[@action='/login_alerts/add/confirm/write/']//input[@placeholder]"));
        public Button ButtonCancel => new Button(Driver, By.XPath($"//form[@action='/login_alerts/add/confirm/write/']//a[text()={ResMiscellaneous.Cancel}]"));
        public Button ButtonConfirm => new Button(Driver, By.XPath($"//form[@action='/login_alerts/add/confirm/write/']//button[text()={ResMiscellaneous.Confirm}]"));
    }
}
