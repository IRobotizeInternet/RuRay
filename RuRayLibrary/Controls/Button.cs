using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RuRayToolbox.CommonControls
{
    public class Button : BaseDOMProperty
    {
        public Button(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
        {
        }
    }
}
