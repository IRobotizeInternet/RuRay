using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Components;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="ListItemSpecificFriends" />.
    /// </summary>
    public class ListItemSpecificFriends : BaseDiv, IListItem
    {
        /// <summary>
        /// Gets the LabelFriendName.
        /// </summary>
        public Label LabelFriendName =>
            new Label(Driver, By.XPath($"{BaseXPath}/div[{XIndex}]/div/div/div/div/div[2]/div/div/div/div[1]/span"));

        /// <summary>
        /// Gets the ButtonRemoveFromFriendsWhoWontSeeYourPost.
        /// </summary>
        public Button ButtonRemoveFromFriendsWhoWontSeeYourPost =>
            new Button(Driver, By.XPath($"{BaseXPath}/div[{XIndex}]//div[@role='img']"));

        /// <summary>
        /// Gets the ButtonAddToFriendsWhoWontSeeYourPost.
        /// </summary>
        public Button ButtonAddToFriendsWhoWontSeeYourPost =>
            new Button(Driver, By.XPath($"{BaseXPath}/div[{XIndex}]//div[@role='img']"));

        /// <summary>
        /// Gets or sets the XIndex.
        /// </summary>
        public int XIndex { get; set; }

        /// <summary>
        /// Gets or sets the YIndex.
        /// </summary>
        public int YIndex { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListItemSpecificFriends"/> class.
        /// </summary>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        /// <param name="index">The index<see cref="int"/>.</param>
        public ListItemSpecificFriends(string baseXPath, int index = 1)
        {
            XIndex = index;
            BaseXPath = baseXPath ?? $"//form//div[@aria-label='{ResCreatePost.Friends}']";
        }
    }
}
