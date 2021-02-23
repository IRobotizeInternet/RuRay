using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Controls.TriggerControls;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.App.LoggedIn.Pages.Base
{
    public class DivComments : BaseDialog
    {
        public DivComments(RemoteWebDriver driver, string baseXPath = null) : base(driver)
        {
            BaseXPath = baseXPath;
        }

        protected override By ByForDialog => By.XPath($");

        public TextBox TextBoxWriteAComment =>
            new TextBox(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.WriteAComment}'][@role='textbox']"));

        public EventTriggerButton<DialogInsertAnEmoji> EventTriggerButtonInsertAnEmoji =>
            new EventTriggerButton<DialogInsertAnEmoji>(Driver, By.XPath($"{BaseXPath}//div[@aria-label="Insert an emoji"]"));

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