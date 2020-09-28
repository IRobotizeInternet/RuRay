using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.CommonControls;

namespace RobotizeLibrary.CommonControls
{
    public class TextBox : BaseDOMProperty
    {
        public TextBox(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
        {
        }
    }
}
