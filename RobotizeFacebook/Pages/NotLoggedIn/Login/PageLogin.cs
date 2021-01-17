using OpenQA.Selenium;
using RobotizeFacebook.Pages.LoggedUser;
using RobotizeFacebook.Pages.NotLoggedIn;
using RobotizeFacebook.Pages.PasswordRecovery;
using RobotizeFacebook.Utilities;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls.TriggerControls;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.Pages
{
    public class PageLogin : PageBase
    {
        public override string PageUrl => "/";

        public TextBox TextBoxUserName => new TextBox(Driver, By.XPath("//input[@name='email']"));
        public TextBox TextBoxPassword => new TextBox(Driver, By.XPath("//input[@name='pass']"));
        public EventTriggerButton<PageHome> ButtonLogin => new EventTriggerButton<PageHome>(Driver, By.XPath("//button[@name='login']"));

        public Hyperlink<PasswordRecoveryPage> ButtonForgotPassword
                 => new Hyperlink<PasswordRecoveryPage>(Driver, By.LinkText(ResLoginPage.ForgotPassword));

        public Hyperlink<DialogCreateNewAccount> HyperlinkCreateNewAccount
                => new Hyperlink<DialogCreateNewAccount>(Driver, By.XPath("//a[@data-testid='open-registration-form-button']"));

        public override By ByForPage => throw new System.NotImplementedException();

        public PageHome Login()
        {
            TextBoxUserName.SetData(AppSettings.UserName);
            TextBoxPassword.SetData(AppSettings.Password);
            return ButtonLogin.Click();
        }
    }
}
