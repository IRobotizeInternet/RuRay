using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

using RobotizeToolbox.Extensions;
using System.Threading;

namespace RobotizeToolbox.CommonControls
{
    public class Dropdown : BaseDOMProperty
    {
        public Dropdown(RemoteWebDriver driver, By by) : base(driver, by) { }

        public SelectElement Elements
        {
            get
            {
                if (!Driver.TryFindElement(ByForElement, out var webElement)) throw new InvalidElementStateException();
                ScrollToElement(webElement);
                return new SelectElement(webElement);
            }
        }

        public void Select(string itemToSelect)
        {
            Thread.Sleep(1500);

            ScrollToElement();
            //var dropdownElement = Driver.FindSingleVisibleElementWait(ByForElement);
            //var selectElement = new SelectElement(dropdownElement);
            //selectElement.SelectByText(itemToSelect);

            Thread.Sleep(2000);
        }
    }
}
