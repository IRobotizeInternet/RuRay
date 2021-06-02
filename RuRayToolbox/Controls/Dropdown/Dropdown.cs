using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RuRayToolbox.Extensions;

namespace RuRayToolbox.CommonControls
{
    /// <summary>
    /// Defines the <see cref="Dropdown" />.
    /// </summary>
    public class Dropdown : BaseDOMObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dropdown"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <param name="by">The by<see cref="By"/>.</param>
        public Dropdown(RemoteWebDriver driver, By by) : base(driver, by)
        {
        }

        /// <summary>
        /// Gets the Elements.
        /// </summary>
        public SelectElement Elements
        {
            get
            {
                if (!Driver.TryFindElement(ByForElement, out var webElement))
                {
                    throw new InvalidElementStateException();
                }

                ScrollToElement(webElement);
                return new SelectElement(webElement);
            }
        }

        /// <summary>
        /// The Select.
        /// </summary>
        /// <param name="itemToSelect">The itemToSelect<see cref="string"/>.</param>
        public void Select(string itemToSelect)
        {
            Thread.Sleep(1500);

            //ScrollToElement();
            //var dropdownElement = Driver.FindSingleVisibleElementWait(ByForElement);
            //var selectElement = new SelectElement(dropdownElement);
            //selectElement.SelectByText(itemToSelect);

            Thread.Sleep(2000);
        }
    }
}
