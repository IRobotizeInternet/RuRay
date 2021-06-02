using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRayToolbox.CommonControls;

namespace RuRayToolbox.Controls.TriggerControls
{
    /// <summary>
    /// Defines the <see cref="Hyperlink{EventResult}" />.
    /// </summary>
    /// <typeparam name="EventResult">.</typeparam>
    public class Hyperlink<EventResult> where EventResult : class
    {
        /// <summary>
        /// Defines the _driver.
        /// </summary>
        private readonly RemoteWebDriver _driver;

        /// <summary>
        /// Defines the _element.
        /// </summary>
        private readonly BaseDOMObject _element;

        /// <summary>
        /// Initializes a new instance of the <see cref="Hyperlink{EventResult}"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <param name="byForElement">The byForElement<see cref="By"/>.</param>
        public Hyperlink(
            RemoteWebDriver driver,
            By byForElement)
        {
            _driver = driver;
            _element = new BaseDOMObject(driver, byForElement);
        }

        /// <summary>
        /// The Click.
        /// </summary>
        /// <returns>The <see cref="EventResult"/>.</returns>
        public EventResult Click()
        {
            _element.Click();
            Thread.Sleep(5000);
            return (EventResult)Activator.CreateInstance(typeof(EventResult));
        }
    }
}
