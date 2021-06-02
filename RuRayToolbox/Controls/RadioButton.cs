using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRayToolbox.CommonControls;

namespace RuRayToolbox.Controls
{
    public class RadioButton : BaseDOMObject
    {
        public RadioButton(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
        {
        }
    }
}