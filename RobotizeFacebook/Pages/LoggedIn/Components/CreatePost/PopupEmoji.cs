using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.Pages
{
    public class PopupEmoji : BasePopup
    {
        public PopupEmoji(RemoteWebDriver driver) : base(driver)
        {
            
        }

        protected override By ByForDialog => By.XPath($"//div[@role='dialog']//h3[text()='{ResCreatePost.RecentlyUsed}']");
    }
}
