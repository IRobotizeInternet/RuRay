using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeLibrary.Controls;
using RobotizeLibrary.Dialogs;
using RobotizeLibrary.Resources;

namespace RobotizeFacebook.Pages.LoggedIn.Stories.Create
{
    public class DialogStoryPrivacy : BaseDialog
    {
        public DialogStoryPrivacy(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
            BaseXPath = $"//div[@aria-label='{ResMiscellaneous.StoryPrivacy}']";
        }

        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResMiscellaneous.StoryPrivacy}']");
        
        public RadioButton RButtonPublic => 
            new RadioButton(Driver, By.XPath($"{BaseXPath}//div[@role='radio' and .//span[contains(text(), '{ResCreatePost.Public}')]] "));
        public RadioButton RButtonFriends =>
            new RadioButton(Driver, By.XPath($"{BaseXPath}//div[@role='radio' and .//span[contains(text(), '{ResCreatePost.Friends}')]] "));
        public RadioButton RButtonCustom =>
            new RadioButton(Driver, By.XPath($"{BaseXPath}//div[@role='radio' and .//span[contains(text(), '{ResCreatePost.Custom}')]] "));
    }
}
