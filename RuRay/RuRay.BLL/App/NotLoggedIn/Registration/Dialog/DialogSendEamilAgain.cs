using OpenQA.Selenium;
using RuRayFacebook.App.LoggedIn.Pages;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.NotLoggedIn.Login.Dialog
{
    /// <summary>
    /// Defines the <see cref="DialogSendEamilAgain" />.
    /// </summary>
    public class DialogSendEamilAgain : BaseDialog
    {
        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => throw new System.NotImplementedException();

        /// <summary>
        /// Initializes a new instance of the <see cref="DialogSendEamilAgain"/> class.
        /// </summary>
        public DialogSendEamilAgain()
        {
        }

        /// <summary>
        /// Gets the ButtonChangeEmail.
        /// </summary>
        public EventTriggerButton<DialogChangeEmail> ButtonChangeEmail =>
            new EventTriggerButton<DialogChangeEmail>(Driver, By.XPath("//a[@class='_42ft _4jy0 layerCancel _8n28 uiOverlayButton _4jy4 _517h _51sy']"));

        /// <summary>
        /// Gets the ButtonOK.
        /// </summary>
        public Button ButtonOK => new Button(Driver, By.XPath("//a[@class='_42ft _4jy0 layerCancel _2z1w _8n28 _8n2a uiOverlayButton _4jy4 _4jy1 selected _51sy']"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
