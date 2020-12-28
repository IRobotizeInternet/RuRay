using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeLibrary.CommonControls;
using RobotizeLibrary.Dialogs;
using RobotizeLibrary.Resources;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class DialogAddToYourPost : BaseDialog
    {
        public DialogAddToYourPost(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
            BaseXPath = "//form[@method='POST']";
        }

        protected override By ByForDialog => By.XPath($"//form[@method='POST']//span[text()='{ResCreatePost.WatchParty}']");

        public Button ButtonAddToYourPost => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResCreatePost.PhotoOrVideo}']"));
        public Button ButtonTagFriends => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResCreatePost.TagFriends}']"));
        public Button ButtonFeelingOrActivity => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResCreatePost.FeelingOrActivity}']"));
        public Button ButtonCheckIn => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResCreatePost.CheckIn}']"));
        public Button ButtonGIF => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResCreatePost.GIF}']"));
        public Button ButtonLiveVideo => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResCreatePost.LiveVideo}']"));
        public Button ButtonWatchParty => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResCreatePost.WatchParty}']"));
        public Button ButtonRaiseMoney => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResCreatePost.RaiseMoney}']"));

        public Button ButtonBack => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResCreatePost.RaiseMoney}']"));
    }
}
