using System.Collections.Generic;
using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogSpecificFriends" />.
    /// </summary>
    public class DialogSpecificFriends : BaseSaveCancelDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogSpecificFriends"/> class.
        /// </summary>
        public DialogSpecificFriends()
        {
            BaseXPath = $"//form[@method='POST']//div[./div/div/h2/span/span[text()='{ResCreatePost.SpecificFriends}']]";
        }

        /// <summary>
        /// Gets the ScrollFriendsExcepts.
        /// </summary>
        public ScrollControl<ListItemSpecificFriends> ScrollFriendsExcepts =>
            new ScrollControl<ListItemSpecificFriends>(Driver, $"//form//div[@aria-label='{ResCreatePost.Friends}']/div");

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//form[@method='POST']//span[text()='{ResCreatePost.SpecificFriends}']");

        /// <summary>
        /// Gets the ComboboxSearchFriends.
        /// </summary>
        public ComboboxSharingWithYourFriends ComboboxSearchFriends => new ComboboxSharingWithYourFriends(Driver, BaseXPath);

        /// <summary>
        /// Gets the FriendsWhoWontSeeYourPost.
        /// </summary>
        public IEnumerable<IWebElement> FriendsWhoWontSeeYourPost =>
             Driver.FindElements(By.XPath($"//form[@method='POST']//div[@role='grid'][contains(@aria-label, '{ResCreatePost.FriendsWhoWillSeeYourPost}')]//div[@role='button']"));

        /// <summary>
        /// Gets the TriggerSaveChangesButton.
        /// </summary>
        public EventTriggerButton<DialogCreatePost> TriggerSaveChangesButton =>
            new EventTriggerButton<DialogCreatePost>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.SaveChanges}']"));

        /// <summary>
        /// Gets the TriggerCancelChangesButton.
        /// </summary>
        public EventTriggerButton<DialogCreatePost> TriggerCancelChangesButton =>
            new EventTriggerButton<DialogCreatePost>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.Cancel}']"));
    }
}
