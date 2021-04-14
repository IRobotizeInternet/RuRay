using OpenQA.Selenium;
using Robotize.BLL.Resources;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogNewsFeedPreferences : BaseDialog
    {
        public DialogNewsFeedPreferences()
        {
        }

        private readonly string _baseXPath = $"//div[@aria-label='{ResMiscellaneous.NewsFeedPreferences}' and @role='dialog']";
        protected override By ByForDialog => By.XPath(_baseXPath);

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
