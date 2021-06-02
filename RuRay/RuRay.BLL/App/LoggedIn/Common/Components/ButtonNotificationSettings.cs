using OpenQA.Selenium.Remote;

namespace RuRayFacebook.App.LoggedIn.CommonComponents
{
    /// <summary>
    /// Defines the <see cref="ButtonNotificationSettings" />.
    /// </summary>
    public abstract class ButtonNotificationSettings
    {
        /// <summary>
        /// Defines the _driver.
        /// </summary>
        private readonly RemoteWebDriver _driver;

        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonNotificationSettings"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        public ButtonNotificationSettings(RemoteWebDriver driver)
        {
            _driver = driver;
        }
    }
}
