using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DivMarketPlaceMenu
    {
        private readonly RemoteWebDriver _driver;
        public DivMarketPlaceMenu(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        public EventTriggerButton<PageMarketplace> TriggerButtonBrowseAllPage =>
            new EventTriggerButton<PageMarketplace>(_driver, By.XPath($"//span[text()='{ResLeftNav.BrowseAll}']"));
        public EventTriggerButton<PageMarketplace> TriggerButtonNotifications =>
            new EventTriggerButton<PageMarketplace>(_driver, By.XPath($"//span[text()='{ResLeftNav.Notifications}']"));
        public EventTriggerButton<PageMarketplace> TriggerButtonCart =>
            new EventTriggerButton<PageMarketplace>(_driver, By.XPath($"//span[text()='{ResLeftNav.Cart}']"));
        public EventTriggerButton<PageMarketplace> TriggerButonYourAccount =>
            new EventTriggerButton<PageMarketplace>(_driver, By.XPath($"//span[text()='{ResLeftNav.YourAccount}']"));
    }
}
