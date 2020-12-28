using OpenQA.Selenium;
using RobotizeFacebook.Pages.LoggedUser;
using RobotizeFacebook.Pages.NotLoggedIn;
using RobotizeFacebook.Pages.PasswordRecovery;
using RobotizeFacebook.Utilities;
using RobotizeLibrary.CommonControls;
using RobotizeLibrary.Controls.TriggerControls;
using RobotizeFacebook.Resources;

namespace RobotizeFacebook.Pages
{
    public class PageLogin : PageBase
    {
        public override string PageUrl => "/";

        public TextBox TextBoxUserName => new TextBox(Driver, By.XPath("//input[@name='email']"));
        public TextBox TextBoxPassword => new TextBox(Driver, By.XPath("//input[@name='pass']"));
        public EventTriggerButton<PageHome> ButtonLogin => new EventTriggerButton<PageHome>(Driver, Wait, By.XPath("//button[@name='login']"));

        public Hyperlink<PasswordRecoveryPage> ButtonForgotPassword
                 => new Hyperlink<PasswordRecoveryPage>(Driver, Wait, By.LinkText(ResLoginPage.ForgotPassword));

        public Hyperlink<DialogCreateNewAccount> HyperlinkCreateNewAccount
                => new Hyperlink<DialogCreateNewAccount>(Driver, Wait, By.XPath("//a[@data-testid='open-registration-form-button']"));

        public PageHome Login()
        {
            TextBoxUserName.SetData(AppSettings.UserName);
            TextBoxPassword.SetData(AppSettings.Password);
            return ButtonLogin.Click();
        }
    }
}
