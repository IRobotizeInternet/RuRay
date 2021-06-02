using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRayToolbox.CommonControls;

namespace RuRayToolbox.Controls
{
    public class Checkbox : BaseDOMObject
    {
        public Checkbox(RemoteWebDriver driver, By byForCheckbox) : base(driver, byForCheckbox) { }

        /// Use this method to set the checkbox. 
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
