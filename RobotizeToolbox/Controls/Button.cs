using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RobotizeToolbox.CommonControls
{
    public class Button : BaseDOMObject
    {
        public Button(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
        {
        }

        public void Click()
        {
            Thread.Sleep(3000);
            base.Click();
        }
    }
}
