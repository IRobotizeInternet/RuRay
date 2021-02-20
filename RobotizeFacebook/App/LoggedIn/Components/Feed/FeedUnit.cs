using OpenQA.Selenium;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            new EventTriggerButton<DialogSeeWhoReactedToThis>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[@aria-label='See who reacted to this']"));
        public EventTriggerButton<DialogSeeWhoReactedToThis> EventTriggerButtonNumberOfPeopleReacted =>
            new EventTriggerButton<DialogSeeWhoReactedToThis>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[@aria-label='See who reacted to this']/following-sibling::div"));
        public EventTriggerButton<DialogComments> EventTriggerButtonComments =>
           new EventTriggerButton<DialogComments>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[contains(text(), 'Comments')]"));
        public EventTriggerButton<DialogPeopleWhoSharedThis> EventTriggerButtonPeopleWhoSharedThis =>
            new EventTriggerButton<DialogPeopleWhoSharedThis>(Driver, By.XPath($"{FeedCommentControlsXPath}//button[@aria-label='Voice Selector']"));

        public Button ButtonLike => new Button(Driver, By.XPath($"{FeedCommentControlsXPath}//span[text()='Like']"));
        public EventTriggerButton<DialogComments> EventTriggerButtonComment =>
           new EventTriggerButton<DialogComments>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[text()='Comment']"));
        public EventTriggerButton<DialogShare> EventTriggerButtonShare =>
           new EventTriggerButton<DialogShare>(Driver, By.XPath($"{FeedCommentControlsXPath}//span[text()='Share']"));
        public EventTriggerButton<DialogChooseHowToInteract> EventTriggerButtonChooseHowToInteract => 
            new EventTriggerButton<DialogChooseHowToInteract>(Driver, By.XPath($"{FeedCommentControlsXPath}//button[@aria-label='Voice Selector']"));

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
