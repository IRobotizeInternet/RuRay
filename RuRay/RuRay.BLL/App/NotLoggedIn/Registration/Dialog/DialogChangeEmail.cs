using OpenQA.Selenium;
using RuRayFacebook.App.LoggedIn.Pages;
using RuRayToolbox.CommonControls;

namespace RuRayFacebook.App.NotLoggedIn.Login.Dialog
{
    /// <summary>
    /// Defines the <see cref="DialogChangeEmail" />.
    /// </summary>
    public class DialogChangeEmail : BaseDialog
    {
        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => throw new System.NotImplementedException();

        /// <summary>
        /// Initializes a new instance of the <see cref="DialogChangeEmail"/> class.
        /// </summary>
        public DialogChangeEmail()
        {
        }

        /// <summary>
        /// Gets the ButtonCloseDialog.
        /// </summary>
        public Button ButtonCloseDialog => new Button(Driver, By.XPath("//a[@class='_42ft _4jy0 layerConfirm _8n28 _8n2a uiOverlayButton _4jy3 _4jy1 selected _51sy']"));

        /// <summary>
        /// Gets the TextBoxNewEmailOrMobileNumber.
        /// </summary>
        public TextBox TextBoxNewEmailOrMobileNumber => new TextBox(Driver, By.XPath("//input[@name='contactpoint']"));

        /// <summary>
        /// Gets the ButtonCancel.
        /// </summary>
        public Button ButtonCancel => new Button(Driver, By.XPath("//a[@class='_42ft _4jy0 layerCancel _8n28 uiOverlayButton _4jy3 _517h _51sy']"));

        /// <summary>
        /// Gets the ButtonAdd.
        /// </summary>
        public Button ButtonAdd => new Button(Driver, By.XPath("//a[@class='_42ft _4jy0 layerConfirm _8n28 _8n2a uiOverlayButton _4jy3 _4jy1 selected _51sy']"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
