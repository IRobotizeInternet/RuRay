using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn
{
    public abstract class ComboboxNavigation : Combobox
    {
        public ComboboxNavigation(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
        {
            BaseXPath = $"//div[@data-pagelet='LeftNavSearchContainer']";
            SearchBoxXPath = $"{BaseXPath}//input[contains(@aria-label,'{ResMiscellaneous.Search}')][@role='combobox']";
            SearchItemsXPath = $"//div[@role='listbox'][@data-pagelet='root']";
        }
    }
}
