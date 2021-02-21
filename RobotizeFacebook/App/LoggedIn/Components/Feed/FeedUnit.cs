using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Controls.TriggerControls;
using System;

namespace RobotizeFacebook.App.LoggedIn.Pages.Base
{
    public class FeedUnit : BaseDriver
    {
        // public 
        public string BaseXPath = "//div[@role='feed']";
        public string FeedUnitIndexPath = "//div[@role='feed']//div[@aria-posinset={0}]/div/div/div/div/div/div/div/div[{1}]";
        public string FeedInfoXPath { get; set; }
        public string FeedHeaderXPath { get; set; }
        public string FeedMainContentXPath { get; set; }
        public string FeedCommentControlsXPath { get; set; }
        public string FeedCommentsXPath { get; set; }

        protected FeedUnit(int feedUnitIndex)
        {
            FeedInfoXPath = string.Format(FeedUnitIndexPath, feedUnitIndex, 1);
            FeedHeaderXPath = string.Format(FeedUnitIndexPath, feedUnitIndex, 2);
            FeedMainContentXPath = string.Format(FeedUnitIndexPath, feedUnitIndex, 3);
            FeedCommentControlsXPath = $"{string.Format(FeedUnitIndexPath, feedUnitIndex, 4)}/div/div/div[1]";
            FeedCommentsXPath = $"{string.Format(FeedUnitIndexPath, feedUnitIndex, 4)}/div/div/div[2]";
        }

        public EventTriggerButton<DialogSeeWhoReactedToThis> EventTriggerButtonSeeWhoReactedToThis =>
            new EventTriggerButton<DialogSeeWhoReactedToThis>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[@aria-label='{ResHomePage.SeeWhoReactedToThis}']"));
        public EventTriggerButton<DialogSeeWhoReactedToThis> EventTriggerButtonNumberOfPeopleReacted =>
            new EventTriggerButton<DialogSeeWhoReactedToThis>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[@aria-label='{ResHomePage.SeeWhoReactedToThis}']/following-sibling::div"));
        public EventTriggerButton<DialogComments> EventTriggerButtonShowHideComments =>
           new EventTriggerButton<DialogComments>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[contains(text(), '{ResHomePage.Comments}')]"));
        public EventTriggerButton<DialogPeopleWhoSharedThis> EventTriggerButtonPeopleWhoSharedThis =>
            new EventTriggerButton<DialogPeopleWhoSharedThis>(Driver, By.XPath($"{FeedCommentControlsXPath}//button[@aria-label='{ResHomePage.Shares}']"));

        public Button ButtonLike => new Button(Driver, By.XPath($"{FeedCommentControlsXPath}//span[text()='{ResHomePage.Like}']"));
        public EventTriggerButton<DialogComments> EventTriggerButtonComment =>
           new EventTriggerButton<DialogComments>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[text()='{ResHomePage.Comment}']"));
        public EventTriggerButton<DialogShare> EventTriggerButtonShare =>
           new EventTriggerButton<DialogShare>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[text()='{ResHomePage.Share}']"));
        public EventTriggerButton<DialogChooseHowToInteract> EventTriggerButtonChooseHowToInteract => 
            new EventTriggerButton<DialogChooseHowToInteract>(Driver, By.XPath($"{FeedCommentControlsXPath}//button[@aria-label='{ResHomePage.VoiceSelector}']"));

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }

    public class CommentDiv : BaseDiv
    {
        public Hyperlink<PopupUserProfile> HyperlinkCommenterName =>
            new Hyperlink<PopupUserProfile>(Driver, By.XPath(""));

        public Button ButtonLike => new Button(Driver, By.XPath(""));
        public Button ButtonReply => new Button(Driver, By.XPath(""));
        public Button ButtonShare => new Button(Driver, By.XPath(""));

        public EventTriggerButton<DialogHideOrReport> EventTriggerButtonHideOrReport =>
            new EventTriggerButton<DialogHideOrReport>(Driver, By.XPath(""));
        public Label LabelWhenUserCommentThis => new Label(Driver, By.XPath(""));
    }
}
