using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls.TriggerControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="HeaderRightMenu" />.
    /// </summary>
    public class HeaderRightMenu : BaseDriver
    {
        // Items in the right.
        /// <summary>
        /// Defines the BaseRigthXPath.
        /// </summary>
        private readonly string BaseRigthXPath = "//div[@role='navigation']";

        /// <summary>
        /// Gets the HyperLinkUserProfile.
        /// </summary>
        public Hyperlink<PageUserTimeline> HyperLinkUserProfile =>
            new Hyperlink<PageUserTimeline>(Driver, By.XPath("//a[@href='/me/']/parent::div"));

        /// <summary>
        /// Gets the DialogButtonToCreate.
        /// </summary>
        public Hyperlink<PopupCreate> DialogButtonToCreate =>
            new Hyperlink<PopupCreate>(Driver, By.XPath($"{BaseRigthXPath}//div[contains(@aria-label, '{ResHomePageHeader.Create}'  or contains(@aria-label, '{ResCreatePost.Menu}'))]"));

        /// <summary>
        /// Gets the DialogButtonMessanger.
        /// </summary>
        public Hyperlink<PopupMessanger> DialogButtonMessanger =>
            new Hyperlink<PopupMessanger>(Driver, By.XPath($"{BaseRigthXPath}//div[contains(@aria-label, '{ResHomePageHeader.Messenger}')][1]"));

        /// <summary>
        /// Gets the DialogButtonNotifications.
        /// </summary>
        public Hyperlink<PopupNotifications> DialogButtonNotifications =>
            new Hyperlink<PopupNotifications>(Driver, By.XPath($"{BaseRigthXPath}//div[contains(@aria-label, '{ResHomePageHeader.Notifications}')][1]"));

        /// <summary>
        /// Gets the LabelMessangerCount.
        /// </summary>
        public Label LabelMessangerCount =>
            new Label(Driver, By.XPath($"{BaseRigthXPath}//div[contains(@aria-label,'{ResHomePageHeader.Messenger}')][2]//span//span"));

        /// <summary>
        /// Gets the LabelNotificationsCount.
        /// </summary>
        public Label LabelNotificationsCount =>
            new Label(Driver, By.XPath($"{BaseRigthXPath}//div[contains(@aria-label,'{ResHomePageHeader.Notifications}')][2]//span//span"));

        /// <summary>
        /// Gets the EventTriggerButtonAccount.
        /// </summary>
        public Hyperlink<PopupAccount> EventTriggerButtonAccount =>
            new Hyperlink<PopupAccount>(Driver, By.XPath($"{BaseRigthXPath}//div[contains(@aria-label,'{ResHomePageHeader.Account}')][1]"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
