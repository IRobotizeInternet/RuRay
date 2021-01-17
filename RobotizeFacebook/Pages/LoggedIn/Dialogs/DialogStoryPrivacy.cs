using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.Pages.LoggedIn.Stories.Create
{
    public class DialogStoryPrivacy : BaseDialog
    {
        public DialogStoryPrivacy(RemoteWebDriver driver) : base(driver)
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
