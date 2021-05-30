using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRayToolbox.CommonControls;

namespace RuRayToolbox.CommonControls
{
    public class TextBox : BaseDOMObject
    {
        public TextBox(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
        {
        }
    }
}
