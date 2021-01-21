using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.App
{
    public class DialogAddToYourPost : BaseDialog
    {
        public DialogAddToYourPost(RemoteWebDriver driver) : base(driver)
        {
            BaseXPath = "//form[@method='POST']";
        }

        protected override By ByForDialog => By.XPath($"//form[@method='POST']//span[contains(text(),'{ResCreatePost.WatchParty})']");

        public Button ButtonAddToYourPost => new Button(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.PhotoOrVideo}')]"));
        public Button ButtonTagFriends => new Button(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.TagFriends}')]"));
        public Button ButtonFeelingOrActivity => new Button(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.FeelingOrActivity}')]"));
        public Button ButtonCheckIn => new Button(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.CheckIn}')]"));
        public Button ButtonGIF => new Button(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.GIF}')]"));
        public Button ButtonLiveVideo => new Button(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.LiveVideo}')]"));
        public Button ButtonWatchParty => new Button(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.WatchParty}')]"));
        public Button ButtonRaiseMoney => new Button(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.RaiseMoney}')]"));

        public Button ButtonBack => new Button(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.RaiseMoney}')]"));
    }
}
