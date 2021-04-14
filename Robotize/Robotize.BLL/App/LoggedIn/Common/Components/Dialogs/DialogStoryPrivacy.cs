using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogStoryPrivacy : BaseDialog
    {
        public DialogStoryPrivacy()
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

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
