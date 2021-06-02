using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogIgnoreThisConversation" />.
    /// </summary>
    public class DialogIgnoreThisConversation : BaseDialog
    {
        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResHomePage.IgnoreThisConversation}']");

        /// <summary>
        /// Initializes a new instance of the <see cref="DialogIgnoreThisConversation"/> class.
        /// </summary>
        public DialogIgnoreThisConversation()
        {
            BaseXPath = $"//div[@aria-label='{ResHomePage.IgnoreThisConversation}']";
        }

        /// <summary>
        /// Gets the EventTriggerButtonIgnoremessages.
        /// </summary>
        public EventTriggerButton<PopupNewMessage> EventTriggerButtonIgnoremessages =>
            new EventTriggerButton<PopupNewMessage>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.Ignoremessages}'][@tabindex='0']"));

        /// <summary>
        /// Gets the EventTriggerButtonCancel.
        /// </summary>
        public EventTriggerButton<PopupNewMessage> EventTriggerButtonCancel =>
            new EventTriggerButton<PopupNewMessage>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.Cancel}'][@tabindex='0']"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
