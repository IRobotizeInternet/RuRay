using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;
using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PopupComments : BaseDriver
    {
        public string BaseXPath { get; set; }
        public PopupComments(string baseXPath = null)
        {
            BaseXPath = baseXPath;
        }

        protected By ByForDialog => throw new NotImplementedException();

        public TextBox TextBoxWriteAComment =>
           new TextBox(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.WriteAComment}'][@role='textbox']"));

        public EventTriggerButton<PopupMostRelevant> EventTriggerButtonMostRelevantAllCommentsNewest =>
            new EventTriggerButton<PopupMostRelevant>(Driver, By.XPath($"{BaseXPath}//span[[text()='{ResHomePage.MostRelevant}' or text()='{ResHomePage.AllComments}' or text()='{ResHomePage.Newest}']"));

        public EventTriggerButton<DialogChooseAnEmoji> EventTriggerButtonInsertAnEmoji =>
            new EventTriggerButton<DialogChooseAnEmoji>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.InsertAnEmoji}']"));

        public EventTriggerButton<DialogChooseAGIF> EventTriggerButtonCommentWithAGIF =>
            new EventTriggerButton<DialogChooseAGIF>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.CommentWithAGIF}']"));

        public EventTriggerButton<DialogChooseAGIF> EventTriggerButtonPostASticker =>
            new EventTriggerButton<DialogChooseAGIF>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.PostASticker}']"));

        public EventTriggerButton<DialogChooseAGIF> EventTriggerButtonMoreComment =>
           new EventTriggerButton<DialogChooseAGIF>(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResHomePage.MoreComment}')]"));

        public EventTriggerButton<PopupMostRelevant> EventTriggerButtonWriteACommentDotDotDot =>
             new EventTriggerButton<PopupMostRelevant>(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResHomePage.WriteACommentDotDotDot}')]"));

        public Button ButtonViewMoreComment => new Button(Driver, By.XPath(""));

        public DivUserComment UsersComments(string userName)
        {
           return new DivUserComment($"{BaseXPath}/span/following-sibling::ul/li//div[contains(@aria-label,'{userName}')]");
        }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }

    public class PopupMostRelevant : BasePopup
    {
        public PopupMostRelevant()
        {
        }

        protected override By ByForDialog => throw new NotImplementedException();

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
