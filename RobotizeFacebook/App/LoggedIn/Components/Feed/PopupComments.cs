﻿using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Dialogs;
using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PopupComments : BasePopup
    {
        public PopupComments(RemoteWebDriver driver, string baseXPath = null) : base(driver)
        {
            BaseXPath = baseXPath;
        }

        protected override By ByForDialog => throw new NotImplementedException();

        public TextBox TextBoxWriteAComment =>
           new TextBox(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.WriteAComment}'][@role='textbox']"));

        public EventTriggerButton<PopupMostRelevant> EventTriggerButtonMostRelevantAllCommentsNewest =>
            new EventTriggerButton<PopupMostRelevant>(Driver, By.XPath($"{BaseXPath}//span[[text()='{ResHomePage.MostRelevant}' or text()='{ResHomePage.AllComments}' or text()='{ResHomePage.Newest}']"));

        public EventTriggerButton<DialogEmojis> EventTriggerButtonInsertAnEmoji =>
            new EventTriggerButton<DialogEmojis>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.InsertAnEmoji}']"));

        public EventTriggerButton<DialogGIF> EventTriggerButtonCommentWithAGIF =>
            new EventTriggerButton<DialogGIF>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.CommentWithAGIF}']"));

        public EventTriggerButton<DialogGIF> EventTriggerButtonPostASticker =>
            new EventTriggerButton<DialogGIF>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.PostASticker}']"));

        public EventTriggerButton<DialogGIF> EventTriggerButtonMoreComment =>
           new EventTriggerButton<DialogGIF>(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResHomePage.MoreComment}')]"));

        public EventTriggerButton<PopupMostRelevant> EventTriggerButtonWriteACommentDotDotDot =>
             new EventTriggerButton<PopupMostRelevant>(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResHomePage.WriteACommentDotDotDot}')]"));

        public Button ButtonViewMoreComment => new Button(Driver, By.XPath(""));

        public DivUserComment UsersComments(string userName)
        {
           return new DivUserComment(Driver, $"{BaseXPath}/span/following-sibling::ul/li//div[contains(@aria-label,'{userName}')]");
        }
    }

    public class PopupMostRelevant : BasePopup
    {
        public PopupMostRelevant(RemoteWebDriver driver) : base(driver)
        {
        }

        protected override By ByForDialog => throw new NotImplementedException();
    }
}
