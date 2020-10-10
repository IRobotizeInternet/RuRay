using OpenQA.Selenium;
using RobotizeFacebook.Pages.NotLoggedIn.Login.Dialog;
using RobotizeFacebook.Pages;
using RobotizeLibrary.CommonControls;
using RobotizeLibrary.Controls.TriggerControls;

namespace RobotizeFacebook.Pages.NotLoggedIn.Login
{
    public class PageConfirmation : PageBase
    {
        public override string PageUrl => "confirmemail.php";

        public TextBox TextBoxConfirmationCode => new TextBox(Driver, By.XPath("//input[@name='code']"));
        public Hyperlink<DialogSendEamilAgain> HyperlinkSendEmailAgain => 
            new Hyperlink<DialogSendEamilAgain>(Driver, Wait, By.XPath("//div[@id='conf_dialog_middle_components']//div[3]//a"));
        public Hyperlink<DialogChangeEmail> HyperlinkUpdateContactInfo => 
            new Hyperlink<DialogChangeEmail>(Driver, Wait, By.XPath("//a[@href='/change_contactpoint/dialog/']"));
        public EventTriggerButton<DialogSendEamilAgain> ButtonContinue => 
            new EventTriggerButton<DialogSendEamilAgain>(Driver, Wait, By.XPath("//button[@name='confirm']"));
    }
}
