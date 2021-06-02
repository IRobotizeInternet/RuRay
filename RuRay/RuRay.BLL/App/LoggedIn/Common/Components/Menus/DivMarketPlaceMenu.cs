using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DivMarketPlaceMenu" />.
    /// </summary>
    public class DivMarketPlaceMenu
    {
        /// <summary>
        /// Defines the _driver.
        /// </summary>
        private readonly RemoteWebDriver _driver;

        /// <summary>
        /// Initializes a new instance of the <see cref="DivMarketPlaceMenu"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        public DivMarketPlaceMenu(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        /// <summary>
        /// Gets the TriggerButtonBrowseAllPage.
        /// </summary>
        public EventTriggerButton<PageMarketplace> TriggerButtonBrowseAllPage =>
            new EventTriggerButton<PageMarketplace>(_driver, By.XPath($"//span[text()='{ResLeftNav.BrowseAll}']"));

        /// <summary>
        /// Gets the TriggerButtonNotifications.
        /// </summary>
        public EventTriggerButton<PageMarketplace> TriggerButtonNotifications =>
            new EventTriggerButton<PageMarketplace>(_driver, By.XPath($"//span[text()='{ResLeftNav.Notifications}']"));

        /// <summary>
        /// Gets the TriggerButtonCart.
        /// </summary>
        public EventTriggerButton<PageMarketplace> TriggerButtonCart =>
            new EventTriggerButton<PageMarketplace>(_driver, By.XPath($"//span[text()='{ResLeftNav.Cart}']"));

        /// <summary>
        /// Gets the TriggerButonYourAccount.
        /// </summary>
        public EventTriggerButton<PageMarketplace> TriggerButonYourAccount =>
            new EventTriggerButton<PageMarketplace>(_driver, By.XPath($"//span[text()='{ResLeftNav.YourAccount}']"));
    }
}
