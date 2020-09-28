using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeLibrary.Extensions;
using RobotizeToolbox.CommonControls;

namespace RobotizeLibrary.CommonControls
{
    public class Dropdown : BaseDOMProperty
    {
        public Dropdown(RemoteWebDriver driver, By by) : base(driver, by) { }

        private SelectElement Elements
        {
            get
            {
                if (!Driver.TryFindElement(ByForElement, out var webElement)) throw new InvalidElementStateException();
                ScrollToElement(webElement);
                return new SelectElement(webElement);
            }
        }
    }
}
