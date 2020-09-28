using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.CommonControls;

namespace RobotizeLibrary.Controls
{
    public class Checkbox : BaseDOMProperty
    {
        public Checkbox(RemoteWebDriver driver, By byForCheckbox) : base(driver, byForCheckbox) { }
    }
}
