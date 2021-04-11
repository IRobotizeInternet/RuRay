using OpenQA.Selenium;
using RobotizeFacebook.App.LoggedIn.Pages;
using RobotizeToolbox.CommonControls;

namespace RobotizeFacebook.App.NotLoggedIn.Login.Dialog
{
    public class DialogChangeEmail : BaseDialog
    {
        protected override By ByForDialog => throw new System.NotImplementedException();

        public DialogChangeEmail() 
        {
        }

        public Button ButtonCloseDialog => new Button(Driver, By.XPath("//a[@class='_42ft _4jy0 layerConfirm _8n28 _8n2a uiOverlayButton _4jy3 _4jy1 selected _51sy']"));
        public TextBox TextBoxNewEmailOrMobileNumber => new TextBox(Driver, By.XPath("//input[@name='contactpoint']"));
        public Button ButtonCancel => new Button(Driver, By.XPath("//a[@class='_42ft _4jy0 layerCancel _8n28 uiOverlayButton _4jy3 _517h _51sy']"));
        public Button ButtonAdd => new Button(Driver, By.XPath("//a[@class='_42ft _4jy0 layerConfirm _8n28 _8n2a uiOverlayButton _4jy3 _4jy1 selected _51sy']"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
