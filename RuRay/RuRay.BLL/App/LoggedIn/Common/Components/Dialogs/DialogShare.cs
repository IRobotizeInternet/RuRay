using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogShare" />.
    /// </summary>
    public class DialogShare : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogShare"/> class.
        /// </summary>
        public DialogShare()
        {
            BaseXPath = "";
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//span[contains(text(),'{ResHomePage.ShareNow}')]");

        /// <summary>
        /// Gets the ButtonShareNowPublic.
        /// </summary>
        public Button ButtonShareNowPublic =>
           new Button(Driver, By.XPath($"//span[text()='{ResHomePage.ShareNowPublic}']"));

        /// <summary>
        /// Gets the ButtonShareToNewsFeed.
        /// </summary>
        public EventTriggerButton<CreatePost> ButtonShareToNewsFeed =>
            new EventTriggerButton<CreatePost>(Driver, By.XPath($"//span[text()='{ResHomePage.ShareToNewsFeed}']"));

        /// <summary>
        /// Gets the EventTriggerButtonShareToYourStory.
        /// </summary>
        public Button EventTriggerButtonShareToYourStory =>
           new Button(Driver, By.XPath($"//span[text()='{ResHomePage.ShareToYourStory}']"));

        /// <summary>
        /// Gets the EventTriggerButtonSendInMessenger.
        /// </summary>
        public EventTriggerButton<DialogSendInMessenger> EventTriggerButtonSendInMessenger =>
            new EventTriggerButton<DialogSendInMessenger>(Driver, By.XPath($"//span[text()='{ResHomePage.SendInMessenger}']"));

        /// <summary>
        /// Gets the EventTriggerButtonPeopleShareInWhatsApp.
        /// </summary>
        public Button EventTriggerButtonPeopleShareInWhatsApp =>
            new Button(Driver, By.XPath($"//span[text()='{ResHomePage.ShareInWhatsApp}']"));

        /// <summary>
        /// Gets the EventTriggerButtonShareToAgroup.
        /// </summary>
        public Button EventTriggerButtonShareToAgroup =>
          new Button(Driver, By.XPath($"//span[text()='{ResHomePage.ShareToAgroup}']"));

        /// <summary>
        /// Gets the EventTriggerButtonShareToAPage.
        /// </summary>
        public Button EventTriggerButtonShareToAPage =>
            new Button(Driver, By.XPath($"//span[text()='{ResHomePage.ShareToAPage}']"));

        /// <summary>
        /// Gets the EventTriggerButtonShareToYourStoryFriends.
        /// </summary>
        public Button EventTriggerButtonShareToYourStoryFriends =>
            new Button(Driver, By.XPath($"//span[contains(text(),\"{ResHomePage.ShareToYourStory}\"])"));

        /// <summary>
        /// Gets the EventTriggerButtonSendInTwitter.
        /// </summary>
        public Button EventTriggerButtonSendInTwitter =>
          new Button(Driver, By.XPath($"//span[text()='{ResHomePage.SendInTwitter}']"));

        /// <summary>
        /// Gets the EventTriggerButtonCopyLink.
        /// </summary>
        public Button EventTriggerButtonCopyLink =>
            new Button(Driver, By.XPath($"//span[text()='{ResHomePage.CopyLink}']"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
