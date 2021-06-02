using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Components;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="ListItemSeeWhoReactedToThis" />.
    /// </summary>
    public class ListItemSeeWhoReactedToThis : BaseDiv, IListItem
    {
        /// <summary>
        /// Gets the ButtonUserProfile.
        /// </summary>
        public Button ButtonUserProfile =>
            new Button(Driver, By.XPath($"{BaseXPath}[{XIndex}]//img"));

        /// <summary>
        /// Gets the LabelUserName.
        /// </summary>
        public Label LabelUserName =>
            new Label(Driver, By.XPath($"{BaseXPath}[{XIndex}]/div/div/div[2]/div[1]//span]"));

        /// <summary>
        /// Gets the ButtonAddFriendOrFollow.
        /// </summary>
        public Button ButtonAddFriendOrFollow =>
            new Button(Driver, By.XPath($"{BaseXPath}[{XIndex}]//span[text()='{ResHomePage.AddFriend}' or text()='{ResCreatePost.Follow}']"));

        /// <summary>
        /// Gets or sets the XIndex.
        /// </summary>
        public int XIndex { get; set; }

        /// <summary>
        /// Gets or sets the YIndex.
        /// </summary>
        public int YIndex { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListItemSeeWhoReactedToThis"/> class.
        /// </summary>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        /// <param name="index">The index<see cref="int"/>.</param>
        public ListItemSeeWhoReactedToThis(string baseXPath, int index = 1)
        {
            BaseXPath = baseXPath;
            XIndex = index;
        }
    }
}
