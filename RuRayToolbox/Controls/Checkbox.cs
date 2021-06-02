using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRayToolbox.CommonControls;

namespace RuRayToolbox.Controls
{
    /// <summary>
    /// Defines the <see cref="Checkbox" />.
    /// </summary>
    public class Checkbox : BaseDOMObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Checkbox"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <param name="byForCheckbox">The byForCheckbox<see cref="By"/>.</param>
        public Checkbox(RemoteWebDriver driver, By byForCheckbox) : base(driver, byForCheckbox)
        {
        }

        /// Use this method to set the checkbox.
        /// <summary>
        /// The SetCheckbox.
        /// </summary>
        /// <param name="booleanValueToSet">The booleanValueToSet<see cref="bool"/>.</param>
        public void SetCheckbox(bool booleanValueToSet)
        {
            var checkBoxElement = ByForElement.FindElement(Driver);
            if (checkBoxElement.Selected != booleanValueToSet)
            {
                Click();
            }
        }
    }
}
