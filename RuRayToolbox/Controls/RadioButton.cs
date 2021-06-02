using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRayToolbox.CommonControls;

namespace RuRayToolbox.Controls
{
    /// <summary>
    /// Defines the <see cref="RadioButton" />.
    /// </summary>
    public class RadioButton : BaseDOMObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RadioButton"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <param name="byForElement">The byForElement<see cref="By"/>.</param>
        public RadioButton(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
        {
        }
    }
}
