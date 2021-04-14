using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn
{
    public abstract class ComboboxNavigation : Combobox
    {
        public ComboboxNavigation(RemoteWebDriver driver, string baseXPath) : base(driver, By.XPath(baseXPath))
        {
            BaseXPath = baseXPath ?? $"//div[@data-pagelet='LeftNavSearchContainer']";
            SearchBoxXPath = $"{BaseXPath}//input[contains(@aria-label,'{ResMiscellaneous.Search}')][@role='combobox']";
            SearchItemsXPath = $"//div[@role='listbox'][@data-pagelet='root']";
        }
    }
}
