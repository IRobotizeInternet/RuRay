using OpenQA.Selenium;
using RobotizeFacebook.App.LoggedIn.Pages;
using RobotizeFacebook.App.NotLoggedIn.Login.Dialog;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Controls.TriggerControls;

namespace RobotizeFacebook.App.NotLoggedIn.Login
{
    public class PageConfirmation : BasePage
    {
        public override string PageUrl => "confirmemail.php";

        public TextBox TextBoxConfirmationCode => new TextBox(Driver, By.XPath("//input[@name='code']"));
        public Hyperlink<DialogSendEamilAgain> HyperlinkSendEmailAgain => 
            new Hyperlink<DialogSendEamilAgain>(Driver, By.XPath("//div[@id='conf_dialog_middle_components']//div[3]//a"));
        public Hyperlink<DialogChangeEmail> HyperlinkUpdateContactInfo => 
            new Hyperlink<DialogChangeEmail>(Driver, By.XPath("//a[@href='/change_contactpoint/dialog/']"));
        public EventTriggerButton<DialogSendEamilAgain> ButtonContinue => 
            new EventTriggerButton<DialogSendEamilAgain>(Driver, By.XPath("//button[@name='confirm']"));

        public override By ByForPage => throw new System.NotImplementedException();

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
