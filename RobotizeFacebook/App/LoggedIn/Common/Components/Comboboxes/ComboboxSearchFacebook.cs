using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn
{
    public class ComboboxSearchFacebook : Combobox
    {
        public ComboboxSearchFacebook(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
        {
            BaseXPath = $"//input[@role='combobox'][@placeholder='{ResMiscellaneous.SearchFacebook}']/../../../../..";
            SearchBoxXPath = $"{BaseXPath}//input[@type='search']";
            SearchItemsXPath = $"{BaseXPath}//a[@role='presentation']//span[@dir='auto']/span";
        }
    }
}
