using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRayToolbox.CommonControls;

namespace RuRayToolbox.Controls
{
    /// <summary>
    /// Defines the <see cref="FileUploader" />.
    /// </summary>
    public class FileUploader : BaseDOMObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileUploader"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <param name="byForElement">The byForElement<see cref="By"/>.</param>
        public FileUploader(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
        {
        }
    }
}
