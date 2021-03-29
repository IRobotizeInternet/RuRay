using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Controls.TriggerControls;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DivUserComment : BaseDialog
    {
        public DivUserComment(RemoteWebDriver driver, string baseXPath = null) : base(driver)
        {
            BaseXPath = baseXPath;
        }

        public string UserName { get; set; }
        protected override By ByForDialog => By.XPath($"");

        // Please note since we are relying on button text which could change 
        // So we have added all the possible comibinations. 
        public EventTriggerButton<HoverOverLike> ButtonLike =>
            new EventTriggerButton<HoverOverLike>(Driver,
                By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Like}' or " +
                    $"text()='{ResHomePage.Love}' or " +
                    $"text()='{ResHomePage.Angry}' or " +
                    $"text()='{ResHomePage.Sad}' or " +
                    $"text()='{ResHomePage.Care}' or " +
                    $"text()='{ResHomePage.Haha}' or " +
                    $"text()='{ResHomePage.Wow}']"));
        public Button ButtonReply => new Button(Driver, By.XPath($"{BaseXPath}//div[text()='{ResHomePage.Reply}']"));
        public Button ButtonShare => new Button(Driver, By.XPath($"{BaseXPath}//div[text()='{ResHomePage.Share}']"));

        public Label LabelWhenUserCommentThis => new Label(Driver, By.XPath(""));

        public Hyperlink<PopupUserProfile> HyperlinkCommenterName =>
           new Hyperlink<PopupUserProfile>(Driver, By.XPath(""));

        public EventTriggerButton<DialogHideOrReport> EventTriggerButtonHideOrReport =>
            new EventTriggerButton<DialogHideOrReport>(Driver, By.XPath(""));
    }
}