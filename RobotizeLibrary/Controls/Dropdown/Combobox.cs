using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.CommonControls;

namespace RobotizeToolbox.Controls
{
    public class Combobox : BaseDOMProperty
    {
        public Combobox(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
        {

        }
    }
}