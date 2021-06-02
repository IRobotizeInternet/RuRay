using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Components;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="ListItemPeopleWhoSharedThis" />.
    /// </summary>
    public class ListItemPeopleWhoSharedThis : BaseDiv, IListItem
    {
        /// <summary>
        /// Gets the LabelUserName.
        /// </summary>
        public Label LabelUserName =>
            new Label(Driver, By.XPath($"{BaseXPath}[{XIndex}]//strong/span"));

        /// <summary>
        /// Gets the EventTriggerButtonUserName.
        /// </summary>
        public EventTriggerButton<HoverOverUserProfile> EventTriggerButtonUserName =>
            new EventTriggerButton<HoverOverUserProfile>(Driver, By.XPath($"{BaseXPath}[{XIndex}]//strong/span"));

        /// <summary>
        /// Gets the ButtonLike.
        /// </summary>
        public EventTriggerButton<HoverOverLike> ButtonLike =>
           new EventTriggerButton<HoverOverLike>(Driver, By.XPath($"{BaseXPath}[{XIndex}]{Constants.LikeOptions}"));

        /// <summary>
        /// Gets the ButtonSendThisToFriendsOrPostItOnYourTimeline.
        /// </summary>
        public Button ButtonSendThisToFriendsOrPostItOnYourTimeline =>
            new Button(Driver, By.XPath($"{BaseXPath}{XIndex}//div[@aria-label=\"{ResCreatePost.SendThisToFriendsOrPostItOnYourTimeline}\"]"));

        /// <summary>
        /// Gets the ButtonShowAttachment.
        /// </summary>
        public Button ButtonShowAttachment =>
            new Button(Driver, By.XPath($"{BaseXPath}[{XIndex}]//div[@aria-label=\"{ResCreatePost.ShowAttachment}\"]"));

        /// <summary>
        /// Gets the EventTriggerButtonDotDotDotMenu.
        /// </summary>
        public EventTriggerButton<DialogPeopleWhoSharedThisMenu> EventTriggerButtonDotDotDotMenu =>
            new EventTriggerButton<DialogPeopleWhoSharedThisMenu>(Driver, By.XPath($"{BaseXPath}{XIndex}//div[@aria-haspopup=\"{ResCreatePost.Menu}\"]"));

        /// <summary>
        /// Gets the EventTriggerButtonShare.
        /// </summary>
        public EventTriggerButton<DialogShare> EventTriggerButtonShare =>
           new EventTriggerButton<DialogShare>(Driver, By.XPath($"{BaseXPath}{XIndex}//div[@aria-label=\"{ResCreatePost.Share}\"]"));

        /// <summary>
        /// Gets or sets the XIndex.
        /// </summary>
        public int XIndex { get; set; }

        /// <summary>
        /// Gets or sets the YIndex.
        /// </summary>
        public int YIndex { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListItemPeopleWhoSharedThis"/> class.
        /// </summary>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        /// <param name="index">The index<see cref="int"/>.</param>
        public ListItemPeopleWhoSharedThis(string baseXPath, int index = 1)
        {
            BaseXPath = baseXPath;
            XIndex = index;
        }
    }
}
