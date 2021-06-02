using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRayToolbox.CommonControls;

namespace RuRayToolbox.Controls
{
    /// <summary>
    /// Defines the <see cref="EventTriggerButton{EventResult}" />.
    /// </summary>
    /// <typeparam name="EventResult">.</typeparam>
    public class EventTriggerButton<EventResult> : BaseDOMObject where EventResult : class
    {
        /// <summary>
        /// Defines the _element.
        /// </summary>
        private readonly BaseDOMObject _element;

        /// <summary>
        /// Defines the _xPath.
        /// </summary>
        private readonly string _xPath;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventTriggerButton{EventResult}"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <param name="byForElement">The byForElement<see cref="By"/>.</param>
        /// <param name="xPath">The xPath<see cref="string"/>.</param>
        public EventTriggerButton(
            RemoteWebDriver driver,
            By byForElement,
            string xPath = null) : base(driver, byForElement)
        {
            _xPath = xPath;
            _element = new BaseDOMObject(driver, byForElement);
        }

        /// <summary>
        /// The Click.
        /// </summary>
        /// <returns>The <see cref="EventResult"/>.</returns>
        public EventResult Click()
        {
            // TODO: We need to think about this things in future, othere it will cause significant delay. 
            _element.Click();
            Thread.Sleep(2500);
            return _xPath == null
                ? (EventResult)Activator.CreateInstance(typeof(EventResult))
                : (EventResult)Activator.CreateInstance(typeof(EventResult), _xPath);
        }

        /// <summary>
        /// The Hoverover.
        /// </summary>
        /// <returns>The <see cref="EventResult"/>.</returns>
        public EventResult Hoverover()
        {
            // TODO: We need to think about this things in future, othere it will cause significant delay. 
            _element.MoveCursorToElement();
            Thread.Sleep(3000);
            return (EventResult)Activator.CreateInstance(typeof(EventResult));
        }
    }
}
