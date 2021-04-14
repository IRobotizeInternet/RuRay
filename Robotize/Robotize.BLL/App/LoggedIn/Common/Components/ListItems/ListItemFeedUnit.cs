using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Components;
using RobotizeToolbox.Controls;
using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class ListItemFeedUnit : BaseDriver, IListItem
    {
        private string BaseXPath { get; set; }
        private readonly string _feedUnitIndexPath = "{0}//div[@aria-posinset={1}]/div/div/div/div/div/div/div/div[{2}]";
        public string FeedInfoXPath => string.Format(_feedUnitIndexPath, BaseXPath, XIndex, 1);
        public string FeedHeaderXPath => string.Format(_feedUnitIndexPath, BaseXPath, XIndex, 2);
        public string FeedMainContentXPath => string.Format(_feedUnitIndexPath, BaseXPath, XIndex, 3);
        public string FeedCommentControlsXPath => $"{string.Format(_feedUnitIndexPath, BaseXPath, XIndex, 4)}/div/div/div[1]";
        public string FeedCommentsXPath => $"{string.Format(_feedUnitIndexPath, BaseXPath, XIndex, 4)}/div/div/div[2]";
        public int XIndex { get; set; }
        
        public ListItemFeedUnit(string baseXPath, int index = 1)
        {
            BaseXPath = baseXPath;
            XIndex = index;
        }

        public EventTriggerButton<DialogSeeWhoReactedToThis> EventTriggerButtonSeeWhoReactedToThis =>
            new EventTriggerButton<DialogSeeWhoReactedToThis>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[@aria-label='{ResHomePage.SeeWhoReactedToThis}']"));
        public EventTriggerButton<DialogSeeWhoReactedToThis> EventTriggerButtonNumberOfPeopleReacted =>
            new EventTriggerButton<DialogSeeWhoReactedToThis>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[@aria-label='{ResHomePage.SeeWhoReactedToThis}']/following-sibling::div"));
        public EventTriggerButton<PopupComments> EventTriggerButtonShowHideComments =>
           new EventTriggerButton<PopupComments>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[contains(text(), '{ResHomePage.Comments}')]"), FeedCommentsXPath);
        public EventTriggerButton<DialogPeopleWhoSharedThis> EventTriggerButtonPeopleWhoSharedThis =>
            new EventTriggerButton<DialogPeopleWhoSharedThis>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[contains(text(), '{ResHomePage.Shares}')]"));
        public EventTriggerButton<DialogRelatedDiscussions> EventTriggerButtonRelated =>
           new EventTriggerButton<DialogRelatedDiscussions>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[contains(text(), '{ResHomePage.Related}')]"));
        public EventTriggerButton<HoverOverLike> ButtonLike =>
            new EventTriggerButton<HoverOverLike>(Driver, By.XPath($"{FeedCommentControlsXPath}{Constants.LikeOptions}"));

        public EventTriggerButton<PopupComments> EventTriggerButtonComment =>
           new EventTriggerButton<PopupComments>(Driver, 
               By.XPath($"{FeedCommentControlsXPath}//span[text()='{ResHomePage.Comment}']"),
               $"{FeedCommentControlsXPath}//span[text()='{ResHomePage.Comment}']");
        public EventTriggerButton<DialogShare> EventTriggerButtonShare =>
           new EventTriggerButton<DialogShare>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[text()='{ResHomePage.Share}']"));
        public EventTriggerButton<DialogChooseHowToInteract> EventTriggerButtonChooseHowToInteract => 
            new EventTriggerButton<DialogChooseHowToInteract>(Driver, By.XPath($"{FeedCommentControlsXPath}//button[@aria-label='{ResHomePage.VoiceSelector}']"));

        public int YIndex { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }

    public class PeopleYouMayKnow : BaseDriver, IListItem
    {
        private string BaseXPath { get; set; }
        public int XIndex { get; set; }

        public PeopleYouMayKnow(string baseXPath, int index = 1)
        {
            XIndex = index;
            BaseXPath = baseXPath ?? $"//div[contains(@data-pagelet,'Feed')]//div[@aria-posinset={index}]/div/div/div/div/div/div/div";
        }

        public EventTriggerButton<PageFriends> EventTriggerButtonSeeAll =>
            new EventTriggerButton<PageFriends>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.SeeAll}']"));

        public Button ButtonDotDotDot =>
            new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.ActionsForThisPost}']"));

        public Button ButtonHidePeopleYouMayKnow =>
            new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.HidePeopleYouMayKnow}']"));
        
        public Button ButtonNextItems =>
            new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.NextItems}']"));

        public Button ButtonPreviousItems =>
            new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.PreviousItems}']"));

        public int YIndex { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
