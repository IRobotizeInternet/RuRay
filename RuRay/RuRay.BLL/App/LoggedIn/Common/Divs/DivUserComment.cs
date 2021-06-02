using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;
using RuRayToolbox.Controls.TriggerControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DivUserComment" />.
    /// </summary>
    public class DivUserComment : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DivUserComment"/> class.
        /// </summary>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        public DivUserComment(string baseXPath = null)
        {
            BaseXPath = baseXPath;
        }

        /// <summary>
        /// Gets or sets the UserName.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"");

        // Please note since we are relying on button text which could change 
        // So we have added all the possible comibinations.
        /// <summary>
        /// Gets the ButtonLike.
        /// </summary>
        public EventTriggerButton<HoverOverLike> ButtonLike =>
            new EventTriggerButton<HoverOverLike>(Driver,
                By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Like}' or " +
                    $"text()='{ResHomePage.Love}' or " +
                    $"text()='{ResHomePage.Angry}' or " +
                    $"text()='{ResHomePage.Sad}' or " +
                    $"text()='{ResHomePage.Care}' or " +
                    $"text()='{ResHomePage.Haha}' or " +
                    $"text()='{ResHomePage.Wow}']"));

        /// <summary>
        /// Gets the ButtonReply.
        /// </summary>
        public Button ButtonReply => new Button(Driver, By.XPath($"{BaseXPath}//div[text()='{ResHomePage.Reply}']"));

        /// <summary>
        /// Gets the ButtonShare.
        /// </summary>
        public Button ButtonShare => new Button(Driver, By.XPath($"{BaseXPath}//div[text()='{ResHomePage.Share}']"));

        /// <summary>
        /// Gets the LabelWhenUserCommentThis.
        /// </summary>
        public Label LabelWhenUserCommentThis => new Label(Driver, By.XPath(""));

        /// <summary>
        /// Gets the HyperlinkCommenterName.
        /// </summary>
        public Hyperlink<PopupUserProfile> HyperlinkCommenterName =>
           new Hyperlink<PopupUserProfile>(Driver, By.XPath(""));

        /// <summary>
        /// Gets the EventTriggerButtonHideOrReport.
        /// </summary>
        public EventTriggerButton<DialogHideOrReport> EventTriggerButtonHideOrReport =>
            new EventTriggerButton<DialogHideOrReport>(Driver, By.XPath(""));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
