using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RobotizeToolbox.CommonControls
{
    public class TextBox : BaseDOMObject
    {
        public TextBox(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
        {
        }
    }
}
