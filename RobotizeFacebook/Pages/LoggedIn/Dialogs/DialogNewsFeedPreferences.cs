using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Resources;
using RobotizeLibrary.Dialogs;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class DialogNewsFeedPreferences : BaseDialog
    {
        public DialogNewsFeedPreferences(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        private readonly string _baseXPath = $"//div[@aria-label='{ResMiscellaneous.NewsFeedPreferences}' and @role='dialog']";
        protected override By ByForDialog => By.XPath(_baseXPath);
    }
}
