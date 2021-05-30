using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRayToolbox.CommonControls;

namespace RuRayToolbox.Controls
{
    public class ButtonImage : BaseDOMObject
    {
        public ButtonImage(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
        {
        }
    }
}
