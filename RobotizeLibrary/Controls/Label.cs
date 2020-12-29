using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RobotizeToolbox.CommonControls
{
    public class Label : BaseDOMProperty
    {
        public Label(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
        {
        }
    }
}
