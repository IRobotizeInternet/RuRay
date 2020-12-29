using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.CommonControls;

namespace RobotizeToolbox.Controls
{
    public class RadioButton : BaseDOMProperty
    {
        public RadioButton(RemoteWebDriver driver, By byForElement) : base(driver, byForElement) 
        {
        }
    }
}