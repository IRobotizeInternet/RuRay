using System;
using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="PopupComments" />.
    /// </summary>
    public class PopupComments : BaseDriver
    {
        /// <summary>
        /// Gets or sets the BaseXPath.
        /// </summary>
        public string BaseXPath { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PopupComments"/> class.
        /// </summary>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        public PopupComments(string baseXPath = null)
        {
            BaseXPath = baseXPath;
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected By ByForDialog => throw new NotImplementedException();

        /// <summary>
        /// Gets the TextBoxWriteAComment.
        /// </summary>
        public TextBox TextBoxWriteAComment =>
           new TextBox(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.WriteAComment}'][@role='textbox']"));

        /// <summary>
        /// Gets the EventTriggerButtonMostRelevantAllCommentsNewest.
        /// </summary>
        public EventTriggerButton<PopupMostRelevant> EventTriggerButtonMostRelevantAllCommentsNewest =>
            new EventTriggerButton<PopupMostRelevant>(Driver, By.XPath($"{BaseXPath}//span[[text()='{ResHomePage.MostRelevant}' or text()='{ResHomePage.AllComments}' or text()='{ResHomePage.Newest}']"));

        /// <summary>
        /// Gets the EventTriggerButtonInsertAnEmoji.
        /// </summary>
        public EventTriggerButton<DialogChooseAnEmoji> EventTriggerButtonInsertAnEmoji =>
            new EventTriggerButton<DialogChooseAnEmoji>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.InsertAnEmoji}']"));

        /// <summary>
        /// Gets the EventTriggerButtonCommentWithAGIF.
        /// </summary>
        public EventTriggerButton<DialogChooseAGIF> EventTriggerButtonCommentWithAGIF =>
            new EventTriggerButton<DialogChooseAGIF>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.CommentWithAGIF}']"));

        /// <summary>
        /// Gets the EventTriggerButtonPostASticker.
        /// </summary>
        public EventTriggerButton<DialogChooseAGIF> EventTriggerButtonPostASticker =>
            new EventTriggerButton<DialogChooseAGIF>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.PostASticker}']"));

        /// <summary>
        /// Gets the EventTriggerButtonMoreComment.
        /// </summary>
        public EventTriggerButton<DialogChooseAGIF> EventTriggerButtonMoreComment =>
           new EventTriggerButton<DialogChooseAGIF>(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResHomePage.MoreComment}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonWriteACommentDotDotDot.
        /// </summary>
        public EventTriggerButton<PopupMostRelevant> EventTriggerButtonWriteACommentDotDotDot =>
             new EventTriggerButton<PopupMostRelevant>(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResHomePage.WriteACommentDotDotDot}')]"));

        /// <summary>
        /// Gets the ButtonViewMoreComment.
        /// </summary>
        public Button ButtonViewMoreComment => new Button(Driver, By.XPath(""));

        /// <summary>
        /// The UsersComments.
        /// </summary>
        /// <param name="userName">The userName<see cref="string"/>.</param>
        /// <returns>The <see cref="DivUserComment"/>.</returns>
        public DivUserComment UsersComments(string userName)
        {
            return new DivUserComment($"{BaseXPath}/span/following-sibling::ul/li//div[contains(@aria-label,'{userName}')]");
        }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Defines the <see cref="PopupMostRelevant" />.
    /// </summary>
    public class PopupMostRelevant : BasePopup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PopupMostRelevant"/> class.
        /// </summary>
        public PopupMostRelevant()
        {
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => throw new NotImplementedException();

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
