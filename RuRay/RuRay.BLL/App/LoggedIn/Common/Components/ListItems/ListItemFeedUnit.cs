using System;
using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Components;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="ListItemFeedUnit" />.
    /// </summary>
    public class ListItemFeedUnit : BaseDriver, IListItem
    {
        /// <summary>
        /// Gets or sets the BaseXPath.
        /// </summary>
        private string BaseXPath { get; set; }

        /// <summary>
        /// Defines the _feedUnitIndexPath.
        /// </summary>
        private readonly string _feedUnitIndexPath = "{0}//div[@aria-posinset={1}]/div/div/div/div/div/div/div/div[{2}]";

        /// <summary>
        /// Gets the FeedInfoXPath.
        /// </summary>
        public string FeedInfoXPath => string.Format(_feedUnitIndexPath, BaseXPath, XIndex, 1);

        /// <summary>
        /// Gets the FeedHeaderXPath.
        /// </summary>
        public string FeedHeaderXPath => string.Format(_feedUnitIndexPath, BaseXPath, XIndex, 2);

        /// <summary>
        /// Gets the FeedMainContentXPath.
        /// </summary>
        public string FeedMainContentXPath => string.Format(_feedUnitIndexPath, BaseXPath, XIndex, 3);

        /// <summary>
        /// Gets the FeedCommentControlsXPath.
        /// </summary>
        public string FeedCommentControlsXPath => $"{string.Format(_feedUnitIndexPath, BaseXPath, XIndex, 4)}/div/div/div[1]";

        /// <summary>
        /// Gets the FeedCommentsXPath.
        /// </summary>
        public string FeedCommentsXPath => $"{string.Format(_feedUnitIndexPath, BaseXPath, XIndex, 4)}/div/div/div[2]";

        /// <summary>
        /// Gets or sets the XIndex.
        /// </summary>
        public int XIndex { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListItemFeedUnit"/> class.
        /// </summary>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        /// <param name="index">The index<see cref="int"/>.</param>
        public ListItemFeedUnit(string baseXPath, int index = 1)
        {
            BaseXPath = baseXPath;
            XIndex = index;
        }

        /// <summary>
        /// Gets the EventTriggerButtonSeeWhoReactedToThis.
        /// </summary>
        public EventTriggerButton<DialogSeeWhoReactedToThis> EventTriggerButtonSeeWhoReactedToThis =>
            new EventTriggerButton<DialogSeeWhoReactedToThis>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[@aria-label='{ResHomePage.SeeWhoReactedToThis}']"));

        /// <summary>
        /// Gets the EventTriggerButtonNumberOfPeopleReacted.
        /// </summary>
        public EventTriggerButton<DialogSeeWhoReactedToThis> EventTriggerButtonNumberOfPeopleReacted =>
            new EventTriggerButton<DialogSeeWhoReactedToThis>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[@aria-label='{ResHomePage.SeeWhoReactedToThis}']/following-sibling::div"));

        /// <summary>
        /// Gets the EventTriggerButtonShowHideComments.
        /// </summary>
        public EventTriggerButton<PopupComments> EventTriggerButtonShowHideComments =>
           new EventTriggerButton<PopupComments>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[contains(text(), '{ResHomePage.Comments}')]"), FeedCommentsXPath);

        /// <summary>
        /// Gets the EventTriggerButtonPeopleWhoSharedThis.
        /// </summary>
        public EventTriggerButton<DialogPeopleWhoSharedThis> EventTriggerButtonPeopleWhoSharedThis =>
            new EventTriggerButton<DialogPeopleWhoSharedThis>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[contains(text(), '{ResHomePage.Shares}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonRelated.
        /// </summary>
        public EventTriggerButton<DialogRelatedDiscussions> EventTriggerButtonRelated =>
           new EventTriggerButton<DialogRelatedDiscussions>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[contains(text(), '{ResHomePage.Related}')]"));

        /// <summary>
        /// Gets the ButtonLike.
        /// </summary>
        public EventTriggerButton<HoverOverLike> ButtonLike =>
            new EventTriggerButton<HoverOverLike>(Driver, By.XPath($"{FeedCommentControlsXPath}{Constants.LikeOptions}"));

        /// <summary>
        /// Gets the EventTriggerButtonComment.
        /// </summary>
        public EventTriggerButton<PopupComments> EventTriggerButtonComment =>
           new EventTriggerButton<PopupComments>(Driver,
               By.XPath($"{FeedCommentControlsXPath}//span[text()='{ResHomePage.Comment}']"),
               $"{FeedCommentControlsXPath}//span[text()='{ResHomePage.Comment}']");

        /// <summary>
        /// Gets the EventTriggerButtonShare.
        /// </summary>
        public EventTriggerButton<DialogShare> EventTriggerButtonShare =>
           new EventTriggerButton<DialogShare>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[text()='{ResHomePage.Share}']"));

        /// <summary>
        /// Gets the EventTriggerButtonChooseHowToInteract.
        /// </summary>
        public EventTriggerButton<DialogChooseHowToInteract> EventTriggerButtonChooseHowToInteract =>
            new EventTriggerButton<DialogChooseHowToInteract>(Driver, By.XPath($"{FeedCommentControlsXPath}//button[@aria-label='{ResHomePage.VoiceSelector}']"));

        /// <summary>
        /// Gets or sets the YIndex.
        /// </summary>
        public int YIndex { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Defines the <see cref="PeopleYouMayKnow" />.
    /// </summary>
    public class PeopleYouMayKnow : BaseDriver, IListItem
    {
        /// <summary>
        /// Gets or sets the BaseXPath.
        /// </summary>
        private string BaseXPath { get; set; }

        /// <summary>
        /// Gets or sets the XIndex.
        /// </summary>
        public int XIndex { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleYouMayKnow"/> class.
        /// </summary>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        /// <param name="index">The index<see cref="int"/>.</param>
        public PeopleYouMayKnow(string baseXPath, int index = 1)
        {
            XIndex = index;
            BaseXPath = baseXPath ?? $"//div[contains(@data-pagelet,'Feed')]//div[@aria-posinset={index}]/div/div/div/div/div/div/div";
        }

        /// <summary>
        /// Gets the EventTriggerButtonSeeAll.
        /// </summary>
        public EventTriggerButton<PageFriends> EventTriggerButtonSeeAll =>
            new EventTriggerButton<PageFriends>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.SeeAll}']"));

        /// <summary>
        /// Gets the ButtonDotDotDot.
        /// </summary>
        public Button ButtonDotDotDot =>
            new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.ActionsForThisPost}']"));

        /// <summary>
        /// Gets the ButtonHidePeopleYouMayKnow.
        /// </summary>
        public Button ButtonHidePeopleYouMayKnow =>
            new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.HidePeopleYouMayKnow}']"));

        /// <summary>
        /// Gets the ButtonNextItems.
        /// </summary>
        public Button ButtonNextItems =>
            new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.NextItems}']"));

        /// <summary>
        /// Gets the ButtonPreviousItems.
        /// </summary>
        public Button ButtonPreviousItems =>
            new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.PreviousItems}']"));

        /// <summary>
        /// Gets or sets the YIndex.
        /// </summary>
        public int YIndex { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
