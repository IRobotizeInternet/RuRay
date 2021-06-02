using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogPeopleWhoSharedThisMenu" />.
    /// </summary>
    public class DialogPeopleWhoSharedThisMenu : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogPeopleWhoSharedThisMenu"/> class.
        /// </summary>
        public DialogPeopleWhoSharedThisMenu()
        {
        }

        /// <summary>
        /// Gets the ButtonHideAllFrom.
        /// </summary>
        public Button ButtonHideAllFrom =>
            new Button(Driver, By.XPath($"//div[@role='menuitem']//span[contains(text(),'{ResCreatePost.HideAllFrom}']"));

        /// <summary>
        /// Gets the ButtonUnFollow.
        /// </summary>
        public Button ButtonUnFollow =>
            new Button(Driver, By.XPath($"//div[@role='menuitem']//span[contains(text(),'{ResCreatePost.Unfollow}']"));

        /// <summary>
        /// Gets the ButtonSavePost.
        /// </summary>
        public Button ButtonSavePost =>
            new Button(Driver, By.XPath($"//div[@role='menuitem']//span[contains(text(),'{ResCreatePost.SavePost}'] or contains(text(),'{ResCreatePost.SaveLink}']"));

        /// <summary>
        /// Gets the ButtonTurnOnNotificationsForThisPost.
        /// </summary>
        public Button ButtonTurnOnNotificationsForThisPost =>
            new Button(Driver, By.XPath($"//div[@role='menuitem']//span[contains(text(),'{ResCreatePost.TurnOnNotificationsForThisPost}']"));

        /// <summary>
        /// Gets the ButtonEmbed.
        /// </summary>
        public Button ButtonEmbed =>
            new Button(Driver, By.XPath($"//div[@role='menuitem']//span[contains(text(),'{ResCreatePost.Embed}']"));

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@role='menuitem']//span[text()='{ResCreatePost.TurnOnNotificationsForThisPost}']");

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
