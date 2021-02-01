using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.CommonControls;

namespace RobotizeToolbox.Controls
{
    public class ButtonImage : BaseDOMProperty
    {
        public ButtonImage(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
        {
        }
    }
}
