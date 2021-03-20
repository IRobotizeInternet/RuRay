using OpenQA.Selenium;
using RobotizeFacebook.App.LoggedIn.Pages.Base;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;
using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class FeedUnit : BaseDriver
    {
        public string BaseXPath { get; set; }//= "//div[@role='feed']";
        public string FeedUnitIndexPath = "{0}//div[@aria-posinset={1}]/div/div/div/div/div/div/div/div[{2}]";
        public string FeedInfoXPath => string.Format(FeedUnitIndexPath, BaseXPath, FeedUnitIndex, 1);
        public string FeedHeaderXPath => string.Format(FeedUnitIndexPath, BaseXPath, FeedUnitIndex, 2);
        public string FeedMainContentXPath => string.Format(FeedUnitIndexPath, BaseXPath, FeedUnitIndex, 3);
        public string FeedCommentControlsXPath => $"{string.Format(FeedUnitIndexPath, BaseXPath, FeedUnitIndex, 4)}/div/div/div[1]";
        public string FeedCommentsXPath => $"{string.Format(FeedUnitIndexPath, BaseXPath, FeedUnitIndex, 4)}/div/div/div[2]";
        public int FeedUnitIndex { get; set; }

        public FeedUnit(string baseXPath, int feedUnitIndex)
        {
            BaseXPath = baseXPath;
            FeedUnitIndex = feedUnitIndex;
        }

        public EventTriggerButton<DialogReactions> EventTriggerButtonSeeWhoReactedToThis =>
            new EventTriggerButton<DialogReactions>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[@aria-label='{ResHomePage.SeeWhoReactedToThis}']"));
        public EventTriggerButton<DialogReactions> EventTriggerButtonNumberOfPeopleReacted =>
            new EventTriggerButton<DialogReactions>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[@aria-label='{ResHomePage.SeeWhoReactedToThis}']/following-sibling::div"));
        public EventTriggerButton<PopupComments> EventTriggerButtonShowHideComments =>
           new EventTriggerButton<PopupComments>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[contains(text(), '{ResHomePage.Comments}')]"), FeedCommentsXPath);
        public EventTriggerButton<DialogPeopleWhoSharedThis> EventTriggerButtonPeopleWhoSharedThis =>
            new EventTriggerButton<DialogPeopleWhoSharedThis>(Driver, By.XPath($"{FeedCommentControlsXPath}//button[@aria-label='{ResHomePage.Shares}']"));

        public Button ButtonLike => new Button(Driver, By.XPath($"{FeedCommentControlsXPath}//span[text()='{ResHomePage.Like}']"));
        public EventTriggerButton<PopupComments> EventTriggerButtonComment =>
           new EventTriggerButton<PopupComments>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[text()='{ResHomePage.Comment}']"));
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
