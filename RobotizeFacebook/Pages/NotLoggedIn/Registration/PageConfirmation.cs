using OpenQA.Selenium;
using RobotizeFacebook.Pages.NotLoggedIn.Login.Dialog;
using RobotizeFacebookLibrary.Pages;
using RobotizeLibrary.CommonControls;

namespace RobotizeFacebook.Pages.NotLoggedIn.Login
{
    public class PageConfirmation : PageBase
    {
        public override string PageUrl => "confirmemail.php";

        public TextBox TextBoxConfirmationCode => new TextBox(Driver, By.XPath("//input[@name='code']"));
        public EventTriggerHyperlink<DialogSendEamilAgain> HyperlinkSendEmailAgain => 
            new EventTriggerHyperlink<DialogSendEamilAgain>(Driver, Wait, By.XPath("//div[@id='conf_dialog_middle_components']//div[3]//a"));
        public EventTriggerHyperlink<DialogChangeEmail> HyperlinkUpdateContactInfo => 
            new EventTriggerHyperlink<DialogChangeEmail>(Driver, Wait, By.XPath("//a[@href='/change_contactpoint/dialog/']"));
        public EventTriggerButton<DialogSendEamilAgain> ButtonContinue => 
            new EventTriggerButton<DialogSendEamilAgain>(Driver, Wait, By.XPath("//button[@name='confirm']"));
    }
}
