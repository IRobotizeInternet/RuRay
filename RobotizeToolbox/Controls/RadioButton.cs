using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.CommonControls;

namespace RobotizeToolbox.Controls
{
    public class RadioButton : BaseDOMObject
    {
        public RadioButton(RemoteWebDriver driver, By byForElement) : base(driver, byForElement) 
        {
        }
    }
}