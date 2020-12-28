using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeLibrary.Dialogs;
using RobotizeLibrary.Resources;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class PopupEmoji : BasePopup
    {
        public PopupEmoji(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
           ResEmoji.Shrimp
        }

        protected override By ByForDialog => By.XPath($"//div[@role='dialog']//h3[text()='{ResCreatePost.RecentlyUsed}']");
    }
}
