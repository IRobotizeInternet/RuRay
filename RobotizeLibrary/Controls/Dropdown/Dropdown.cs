using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Extensions;
using System.Threading;

namespace RobotizeToolbox.CommonControls
{
    public class Dropdown : BaseDOMProperty, IDropdownElement
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

        public void Select(string valueToSelect)
        {
            Thread.Sleep(1500);

            ScrollToElement();
            var htmlDropdown = Driver.FindSingleVisibleElementWait(ByForElement);
            var selectElement = new SelectElement(htmlDropdown);
            selectElement.SelectByText(valueToSelect);

            Thread.Sleep(2000);
        }
    }
}
