using OpenQA.Selenium;
using RuRayFacebook.App.LoggedIn.Pages;
using RuRayFacebook.App.NotLoggedIn.Login.Dialog;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;
using RuRayToolbox.Controls.TriggerControls;

namespace RuRayFacebook.App.NotLoggedIn.Login
{
    /// <summary>
    /// Defines the <see cref="PageConfirmation" />.
    /// </summary>
    public class PageConfirmation : BasePage
    {
        /// <summary>
        /// Gets the PageUrl.
        /// </summary>
        public override string PageUrl => "confirmemail.php";

        /// <summary>
        /// Gets the TextBoxConfirmationCode.
        /// </summary>
        public TextBox TextBoxConfirmationCode => new TextBox(Driver, By.XPath("//input[@name='code']"));

        /// <summary>
        /// Gets the HyperlinkSendEmailAgain.
        /// </summary>
        public Hyperlink<DialogSendEamilAgain> HyperlinkSendEmailAgain =>
            new Hyperlink<DialogSendEamilAgain>(Driver, By.XPath("//div[@id='conf_dialog_middle_components']//div[3]//a"));

        /// <summary>
        /// Gets the HyperlinkUpdateContactInfo.
        /// </summary>
        public Hyperlink<DialogChangeEmail> HyperlinkUpdateContactInfo =>
            new Hyperlink<DialogChangeEmail>(Driver, By.XPath("//a[@href='/change_contactpoint/dialog/']"));

        /// <summary>
        /// Gets the ButtonContinue.
        /// </summary>
        public EventTriggerButton<DialogSendEamilAgain> ButtonContinue =>
            new EventTriggerButton<DialogSendEamilAgain>(Driver, By.XPath("//button[@name='confirm']"));

        /// <summary>
        /// Gets the ByForPage.
        /// </summary>
        public override By ByForPage => throw new System.NotImplementedException();

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
