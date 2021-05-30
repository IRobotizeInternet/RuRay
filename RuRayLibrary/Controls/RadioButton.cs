using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRayToolbox.CommonControls;

namespace RuRayToolbox.Controls
{
    public class RadioButton : BaseDOMProperty
    {
        public RadioButton(RemoteWebDriver driver, By byForElement) : base(driver, byForElement) 
        {
        }
    }
}