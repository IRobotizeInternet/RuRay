using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Pages.LoggedIn.Settings.AccountSettings;
using RobotizeLibrary.CommonControls;
using RobotizeLibrary.Controls.TriggerControls;
using RobotizeLibrary.Dialogs;
using RobotizeLibrary.Resources;

namespace RobotizeFacebook.Pages.LoggedIn.Settings.Tabs.Seperator1
{
    public class AdAccount : BaseEditor
    {
        public Label LabelAdAccountContactEmail => new Label(Driver, By.XPath("//div[@id='u_d_2']/div/div/span[1]"));
        public Hyperlink<AdAccountDialog> LinkChangeAdAccountEmail => new Hyperlink<AdAccountDialog>(Driver, Wait, By.XPath("//div[@id='u_d_2']/div/div/span[2]"));
        public Hyperlink<PageAccount> LinkAddAccountSettings => new Hyperlink<PageAccount>(Driver, Wait, By.XPath("//a[@class='bizOK']"));
        public Button ButtonClose => new Button(Driver, By.XPath($"//input[@value={ResMiscellaneous.Close}]"));
    }

    public class AdAccountDialog : BaseDialog
    {
        public AdAccountDialog(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        protected override By ByForDialog => By.XPath($"//div[text()={ResMiscellaneous.ChangeAdAccountContact}]");

        public TextBox TextBoxNewEmail => new TextBox(Driver, By.XPath($"//input[@placeholder={ResMiscellaneous.EnterNewEmail}]"));
        public Button ButtonCancel => new Button(Driver, By.XPath($"//div[text()={ResMiscellaneous.Cancel}]"));
        public Button ButtonChangeEmail => new Button(Driver, By.XPath($"//div[text()={ResMiscellaneous.ChangeEmail}]"));
    }
}
