using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.CommonControls;

namespace RobotizeLibrary.Controls
{
    public class RadioButton : BaseDOMProperty
    {
        public RadioButton(RemoteWebDriver driver, By by) : base(driver, by) { }
    }
}