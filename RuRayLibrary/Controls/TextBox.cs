using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RuRayToolbox.CommonControls
{
    public class TextBox : BaseDOMProperty
    {
        public TextBox(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
        {
        }
    }
}
