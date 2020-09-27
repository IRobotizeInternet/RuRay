using OpenQA.Selenium;
using RobotizeFacebook.Pages.LoggedUser;
using RobotizeFacebook.Pages.PasswordRecovery;
using RobotizeLibrary.CommonControls;

namespace RobotizeFacebookLibrary.Pages
{
    public class LoginPage : BasePage
    {
        public override string PageUrl => "/";

        public TextBox TextBoxUserName => new TextBox(Driver, By.XPath("//input[@name='email']"));
        public TextBox TextBoxPassword => new TextBox(Driver, By.XPath("//input[@name='pass']"));
        public EventTriggerButton<HomePage> ButtonLogin => new EventTriggerButton<HomePage>(Driver, Wait, By.XPath("//button[@name='login']"));
        public EventTriggerHyperlink<PasswordRecoveryPage> ButtonForgotPassword => new EventTriggerHyperlink<PasswordRecoveryPage>(Driver, Wait, By.XPath("//div[@class='_6ltj']//a"));
    }
}
