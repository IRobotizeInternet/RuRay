using OpenQA.Selenium;
using RobotizeFacebook.Pages.LoggedUser;
using RobotizeFacebook.Pages.NotLoggedIn;
using RobotizeFacebook.Pages.PasswordRecovery;
using RobotizeLibrary.CommonControls;
using RobotizeLibrary.Controls.TriggerControls;

namespace RobotizeFacebook.Pages
{
    public class PageLogin : PageBase
    {
        public override string PageUrl => "/";

        public TextBox TextBoxUserName => new TextBox(Driver, By.XPath("//input[@name='email']"));
        public TextBox TextBoxPassword => new TextBox(Driver, By.XPath("//input[@name='pass']"));
        public EventTriggerButton<PageHome> ButtonLogin => new EventTriggerButton<PageHome>(Driver, Wait, By.XPath("//button[@name='login']"));
        
        public EventTriggerHyperlink<PasswordRecoveryPage> ButtonForgotPassword 
                 => new EventTriggerHyperlink<PasswordRecoveryPage>(Driver, Wait, By.XPath("//div[@class='_6ltj']//a")); 

        public EventTriggerHyperlink<DialogCreateNewAccount> HyperlinkCreateNewAccount
                => new EventTriggerHyperlink<DialogCreateNewAccount>(Driver, Wait, By.XPath("//a[@class='_42ft _4jy0 _6lti _4jy6 _4jy2 selected _51sy']"));
    }
}
