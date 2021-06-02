using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRayToolbox.CommonControls;

namespace RuRayToolbox.Controls
{
    /// <summary>
    /// Defines the <see cref="ButtonImage" />.
    /// </summary>
    public class ButtonImage : BaseDOMObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonImage"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <param name="byForElement">The byForElement<see cref="By"/>.</param>
        public ButtonImage(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
        {
        }
    }
}
