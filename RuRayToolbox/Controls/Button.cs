using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RuRayToolbox.CommonControls
{
    /// <summary>
    /// Defines the <see cref="Button" />.
    /// </summary>
    public class Button : BaseDOMObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Button"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <param name="byForElement">The byForElement<see cref="By"/>.</param>
        public Button(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
        {
        }

        /// <summary>
        /// The Click.
        /// </summary>
        public void Click()
        {
            Thread.Sleep(1500);
            base.Click();
        }
    }
}
