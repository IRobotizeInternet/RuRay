using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogBlockUser" />.
    /// </summary>
    public class DialogBlockUser : BaseDialog
    {
        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[contains(@aria-label,'{ResHomePage.Block}')]");

        /// <summary>
        /// Initializes a new instance of the <see cref="DialogBlockUser"/> class.
        /// </summary>
        public DialogBlockUser()
        {
            BaseXPath = $"//div[contains(@aria-label,'{ResHomePage.Block}')]";
        }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets the EventTriggerButtonBlockMessagesAndCalls.
        /// </summary>
        public EventTriggerButton<PopupNewMessage> EventTriggerButtonBlockMessagesAndCalls =>
            new EventTriggerButton<PopupNewMessage>(Driver, By.XPath($"{BaseXPath}//div[text()='{ResHomePage.BlockMessagesAndCalls1}']"));

        /// <summary>
        /// Gets the EventTriggerButtonBlockOnFacebook.
        /// </summary>
        public EventTriggerButton<PopupNewMessage> EventTriggerButtonBlockOnFacebook =>
            new EventTriggerButton<PopupNewMessage>(Driver, By.XPath($"{BaseXPath}//div[text()='{ResHomePage.BlockOnFacebook}']"));

        /// <summary>
        /// Defines the <see cref="DialogConformation" />.
        /// </summary>
        internal class DialogConformation : BaseDialog
        {
            /// <summary>
            /// Gets the ByForDialog.
            /// </summary>
            protected override By ByForDialog => By.XPath($"//div[contains(@aria-label,'{ResHomePage.BlockMessagesAndCalls1}')]");

            /// <summary>
            /// The RunConformance.
            /// </summary>
            public override void RunConformance()
            {
                throw new System.NotImplementedException();
            }

            /// <summary>
            /// Gets the EventTriggerButtonBlock.
            /// </summary>
            public EventTriggerButton<PopupNewMessage> EventTriggerButtonBlock =>
                new EventTriggerButton<PopupNewMessage>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Block}']"));

            /// <summary>
            /// Gets the EventTriggerButtonCancel.
            /// </summary>
            public EventTriggerButton<DialogBlockUser> EventTriggerButtonCancel =>
                new EventTriggerButton<DialogBlockUser>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Cancel}']"));
        }
    }
}
