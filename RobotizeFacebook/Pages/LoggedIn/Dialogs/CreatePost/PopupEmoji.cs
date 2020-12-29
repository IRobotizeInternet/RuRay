using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class PopupEmoji : BasePopup
    {
        public PopupEmoji(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
            
        }

        protected override By ByForDialog => By.XPath($"//div[@role='dialog']//h3[text()='{ResCreatePost.RecentlyUsed}']");
    }
}
