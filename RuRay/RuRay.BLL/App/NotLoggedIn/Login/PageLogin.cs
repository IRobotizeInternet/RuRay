using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayFacebook.App.LoggedIn.Pages;
using RuRayFacebook.Utilities;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;
using RuRayToolbox.Controls.TriggerControls;

namespace RuRayFacebook.App.NotLoggedIn
{
    /// <summary>
    /// Defines the <see cref="PageLogin" />.
    /// </summary>
    public class PageLogin : BasePage
    {
        /// <summary>
        /// Gets the PageUrl.
        /// </summary>
        public override string PageUrl => "/";

        /// <summary>
        /// Gets the TextBoxUserName.
        /// </summary>
        public TextBox TextBoxUserName => new TextBox(Driver, By.XPath("//input[@name='email']"));

        /// <summary>
        /// Gets the TextBoxPassword.
        /// </summary>
        public TextBox TextBoxPassword => new TextBox(Driver, By.XPath("//input[@name='pass']"));

        /// <summary>
        /// Gets the ButtonLogin.
        /// </summary>
        public EventTriggerButton<PageHome> ButtonLogin => new EventTriggerButton<PageHome>(Driver, By.XPath("//button[@name='login']"));

        /// <summary>
        /// Gets the ButtonForgotPassword.
        /// </summary>
        public Hyperlink<PasswordRecoveryPage> ButtonForgotPassword => new Hyperlink<PasswordRecoveryPage>(Driver, By.LinkText(ResLoginPage.ForgotPassword));

        /// <summary>
        /// Gets the HyperlinkCreateNewAccount.
        /// </summary>
        public Hyperlink<DialogCreateNewAccount> HyperlinkCreateNewAccount => new Hyperlink<DialogCreateNewAccount>(Driver, By.XPath("//a[@data-testid='open-registration-form-button']"));

        /// <summary>
        /// Gets the ByForPage.
        /// </summary>
        public override By ByForPage => throw new System.NotImplementedException();

        /// <summary>
        /// The Login.
        /// </summary>
        /// <returns>The <see cref="PageHome"/>.</returns>
        public PageHome Login()
        {
            TextBoxUserName.SetData(AppSettings.UserName);
            TextBoxPassword.SetData(AppSettings.Password);
            return ButtonLogin.Click();
        }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
