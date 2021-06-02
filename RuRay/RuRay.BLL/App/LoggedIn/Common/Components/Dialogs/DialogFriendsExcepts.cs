using System.Collections.Generic;
using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogFriendsExcepts" />.
    /// </summary>
    public class DialogFriendsExcepts : BaseSaveCancelDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogFriendsExcepts"/> class.
        /// </summary>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        public DialogFriendsExcepts(string baseXPath)
        {
            BaseXPath = baseXPath;
            BaseXPath = baseXPath ?? $"//form[@method='POST']/div[.//h2/descendant-or-self::span[text()='{ResCreatePost.FriendsExcept}']]";
        }

        /// <summary>
        /// Gets the ScrollFriendsExcepts.
        /// </summary>
        public ScrollControl<ListItemFriendsExcept> ScrollFriendsExcepts =>
            new ScrollControl<ListItemFriendsExcept>(Driver, $"//form//div[@aria-label='{ResCreatePost.Friends}']/div");

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//form[@method='POST']//span[text()='{ResCreatePost.FriendsExcept}']");

        /// <summary>
        /// Gets the ComboboxSearchFriends.
        /// </summary>
        public ComboboxSharingWithYourFriends ComboboxSearchFriends => new ComboboxSharingWithYourFriends(Driver, BaseXPath);

        /// <summary>
        /// Gets the FriendsWhoWontSeeYourPost.
        /// </summary>
        public IEnumerable<IWebElement> FriendsWhoWontSeeYourPost =>
             Driver.FindElements(By.XPath($"//form[@method='POST']//div[@role='grid'][contains(@aria-label, '{ResCreatePost.FriendsWhoWontSeeYourPost}')]//div[@role='button']"));

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
