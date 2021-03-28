using OpenQA.Selenium;
using RobotizeFacebook.App.LoggedIn.Pages.Base;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Components;
using RobotizeToolbox.Controls;
using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class ListItemFeedUnit : BaseDriver, IListItem
    {
        private string BaseXPath { get; set; }//= "//div[@role='feed']";
        private readonly string _feedUnitIndexPath = "{0}//div[@aria-posinset={1}]/div/div/div/div/div/div/div/div[{2}]";
        public string FeedInfoXPath => string.Format(_feedUnitIndexPath, BaseXPath, FeedUnitIndex, 1);
        public string FeedHeaderXPath => string.Format(_feedUnitIndexPath, BaseXPath, FeedUnitIndex, 2);
        public string FeedMainContentXPath => string.Format(_feedUnitIndexPath, BaseXPath, FeedUnitIndex, 3);
        public string FeedCommentControlsXPath => $"{string.Format(_feedUnitIndexPath, BaseXPath, FeedUnitIndex, 4)}/div/div/div[1]";
        public string FeedCommentsXPath => $"{string.Format(_feedUnitIndexPath, BaseXPath, FeedUnitIndex, 4)}/div/div/div[2]";
        public int FeedUnitIndex { get; set; }

        public ListItemFeedUnit(string baseXPath, int feedUnitIndex = 1)
        {
            BaseXPath = baseXPath;
            FeedUnitIndex = feedUnitIndex;
            //var hoverButton = new EventTriggerButton<HoverOverLike>(Driver, By.XPath($"{BaseXPath}//div[text()='{ResHomePage.Like}']"));
        }

        public EventTriggerButton<DialogSeeWhoReactedToThis> EventTriggerButtonSeeWhoReactedToThis =>
            new EventTriggerButton<DialogSeeWhoReactedToThis>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[@aria-label='{ResHomePage.SeeWhoReactedToThis}']"));
        public EventTriggerButton<DialogSeeWhoReactedToThis> EventTriggerButtonNumberOfPeopleReacted =>
            new EventTriggerButton<DialogSeeWhoReactedToThis>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[@aria-label='{ResHomePage.SeeWhoReactedToThis}']/following-sibling::div"));
        public EventTriggerButton<PopupComments> EventTriggerButtonShowHideComments =>
           new EventTriggerButton<PopupComments>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[contains(text(), '{ResHomePage.Comments}')]"), FeedCommentsXPath);
        public EventTriggerButton<DialogPeopleWhoSharedThis> EventTriggerButtonPeopleWhoSharedThis =>
            new EventTriggerButton<DialogPeopleWhoSharedThis>(Driver, By.XPath($"{FeedCommentControlsXPath}//button[@aria-label='{ResHomePage.Shares}']"));

        // Please note since we are relying on button text which could change 
        // So we have added all the possible comibinations. 
        public EventTriggerButton<HoverOverLike> ButtonLike =>
            new EventTriggerButton<HoverOverLike>(Driver, 
                By.XPath($"{FeedCommentControlsXPath}//span[text()='{ResHomePage.Like}' or " +
                    $"text()='{ResHomePage.Love}' or " +
                    $"text()='{ResHomePage.Angry}' or " +
                    $"text()='{ResHomePage.Sad}' or " +
                    $"text()='{ResHomePage.Care}' or " +
                    $"text()='{ResHomePage.Haha}' or " +
                    $"text()='{ResHomePage.Wow}']"));

        public EventTriggerButton<PopupComments> EventTriggerButtonComment =>
           new EventTriggerButton<PopupComments>(Driver, 
               By.XPath($"{FeedCommentControlsXPath}//span[text()='{ResHomePage.Comment}']"),
               $"{FeedCommentControlsXPath}//span[text()='{ResHomePage.Comment}']");
        public EventTriggerButton<DialogShare> EventTriggerButtonShare =>
           new EventTriggerButton<DialogShare>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[text()='{ResHomePage.Share}']"));
        public EventTriggerButton<DialogChooseHowToInteract> EventTriggerButtonChooseHowToInteract => 
            new EventTriggerButton<DialogChooseHowToInteract>(Driver, By.XPath($"{FeedCommentControlsXPath}//button[@aria-label='{ResHomePage.VoiceSelector}']"));

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
