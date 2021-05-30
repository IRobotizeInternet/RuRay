using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn
{
    public class ComboboxSearchFacebook : Combobox
    {
        public ComboboxSearchFacebook(RemoteWebDriver driver, string baseXPath) : base(driver, By.XPath(baseXPath))
        {
            BaseXPath = baseXPath ?? $"//input[@role='combobox'][@placeholder='{ResMiscellaneous.SearchFacebook}']/../../../../..";
            SearchBoxXPath = $"{BaseXPath}//input[@type='search']";
            SearchItemsXPath = $"{BaseXPath}//a[@role='presentation']//span[@dir='auto']/span";
        }
    }
}
