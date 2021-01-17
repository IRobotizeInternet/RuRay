using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class DialogNewsFeedPreferences : BaseDialog
    {
        public DialogNewsFeedPreferences(RemoteWebDriver driver) : base(driver)
        {
        }

        private readonly string _baseXPath = $"//div[@aria-label='{ResMiscellaneous.NewsFeedPreferences}' and @role='dialog']";
        protected override By ByForDialog => By.XPath(_baseXPath);
    }
}
