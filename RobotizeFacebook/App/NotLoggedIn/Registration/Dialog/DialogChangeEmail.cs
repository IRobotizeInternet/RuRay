using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.App.NotLoggedIn.Login.Dialog
{
    public class DialogChangeEmail : BaseDialog
    {
        protected override By ByForDialog => throw new System.NotImplementedException();

        public DialogChangeEmail(RemoteWebDriver driver) 
            : base(driver)
        {
        }

        public Button ButtonCloseDialog => new Button(Driver, By.XPath("//a[@class='_42ft _4jy0 layerConfirm _8n28 _8n2a uiOverlayButton _4jy3 _4jy1 selected _51sy']"));
        public TextBox TextBoxNewEmailOrMobileNumber => new TextBox(Driver, By.XPath("//input[@name='contactpoint']"));
        public Button ButtonCancel => new Button(Driver, By.XPath("//a[@class='_42ft _4jy0 layerCancel _8n28 uiOverlayButton _4jy3 _517h _51sy']"));
        public Button ButtonAdd => new Button(Driver, By.XPath("//a[@class='_42ft _4jy0 layerConfirm _8n28 _8n2a uiOverlayButton _4jy3 _4jy1 selected _51sy']"));

        
    }
}
