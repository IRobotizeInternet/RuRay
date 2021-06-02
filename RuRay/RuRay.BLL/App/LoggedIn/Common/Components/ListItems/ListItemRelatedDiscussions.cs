using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Components;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="ListItemRelatedDiscussions" />.
    /// </summary>
    public class ListItemRelatedDiscussions : BaseDiv, IListItem
    {
        /// <summary>
        /// Gets the LabelSeeWhoReactedToThis.
        /// </summary>
        public Button LabelSeeWhoReactedToThis => //div[@aria-label='{ResCreatePost.RelatedDiscussions}']
            new Button(Driver, By.XPath($"{BaseXPath}//span[@aria-label='{ResCreatePost.SeeWhoReactedToThis}']/.."));

        /// <summary>
        /// Gets the EventTriggerButtonComments.
        /// </summary>
        public Button EventTriggerButtonComments =>
            new Button(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.Comments}')]"));

        /// <summary>
        /// Gets the ButtonMoreComments.
        /// </summary>
        public Button ButtonMoreComments =>
            new Button(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.MoreComments}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonMoreShares.
        /// </summary>
        public EventTriggerButton<DialogPeopleWhoSharedThis> EventTriggerButtonMoreShares =>
           new EventTriggerButton<DialogPeopleWhoSharedThis>(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.MoreShares}')]"));

        /// <summary>
        /// Gets the ButtonShowAttachment.
        /// </summary>
        public Button ButtonShowAttachment =>
            new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label=\"{ResCreatePost.ShowAttachment}\"]"));

        /// <summary>
        /// Gets the EventTriggerButtonMenu.
        /// </summary>
        public EventTriggerButton<DialogPeopleWhoSharedThisMenu> EventTriggerButtonMenu =>
            new EventTriggerButton<DialogPeopleWhoSharedThisMenu>(Driver, By.XPath($"{BaseXPath}//div[@aria-haspopup=\"{ResCreatePost.Menu}\"]"));

        /// <summary>
        /// Gets or sets the XIndex.
        /// </summary>
        public int XIndex { get; set; }

        /// <summary>
        /// Gets or sets the YIndex.
        /// </summary>
        public int YIndex { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListItemRelatedDiscussions"/> class.
        /// </summary>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        /// <param name="index">The index<see cref="int"/>.</param>
        public ListItemRelatedDiscussions(string baseXPath, int index = 1)
        {
            XIndex = index;
            BaseXPath = baseXPath;
        }
    }
}
