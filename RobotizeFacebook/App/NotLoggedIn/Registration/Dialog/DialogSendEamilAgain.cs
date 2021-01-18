using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.App.NotLoggedIn.Login.Dialog
{
    public class DialogSendEamilAgain : BaseDialog
    {
        protected override By ByForDialog => throw new System.NotImplementedException();

        public DialogSendEamilAgain(RemoteWebDriver driver) 
            : base(driver)
        {

        }

        public EventTriggerButton<DialogChangeEmail> ButtonChangeEmail =>
            new EventTriggerButton<DialogChangeEmail>(Driver, By.XPath("//a[@class='_42ft _4jy0 layerCancel _8n28 uiOverlayButton _4jy4 _517h _51sy']"));
        public Button ButtonOK => new Button(Driver, By.XPath("//a[@class='_42ft _4jy0 layerCancel _2z1w _8n28 _8n2a uiOverlayButton _4jy4 _4jy1 selected _51sy']"));
    }
}
