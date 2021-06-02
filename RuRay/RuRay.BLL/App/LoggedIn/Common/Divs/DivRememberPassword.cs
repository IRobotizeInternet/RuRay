using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;

namespace RuRayFacebook.App.LoggedIn.Components
{
    /// <summary>
    /// Defines the <see cref="DivRememberPassword" />.
    /// </summary>
    public class DivRememberPassword
    {
        /// <summary>
        /// Defines the _driver.
        /// </summary>
        private readonly RemoteWebDriver _driver;

        /// <summary>
        /// Defines the _basePath.
        /// </summary>
        private readonly string _basePath = $"//span[text()='{ResMiscellaneous.DivRememberPassword}']/../../../../../..";

        /// <summary>
        /// Initializes a new instance of the <see cref="DivRememberPassword"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        public DivRememberPassword(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        /// <summary>
        /// Gets the ButtonOK.
        /// </summary>
        public Button ButtonOK => new Button(_driver, By.XPath($"{_basePath}//span[text()='{ResMiscellaneous.OK}']"));

        /// <summary>
        /// Gets the ButtonNotNow.
        /// </summary>
        public Button ButtonNotNow => new Button(_driver, By.XPath($"{_basePath}//span[text()='{ResMiscellaneous.NotNow}']"));
    }
}
