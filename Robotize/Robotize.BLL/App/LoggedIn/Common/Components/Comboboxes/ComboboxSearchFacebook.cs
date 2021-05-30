using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn
{
    public class ComboboxMenu : Combobox
    {
        public ComboboxMenu(RemoteWebDriver driver, string baseXPath) : base(driver, By.XPath(baseXPath))
        {
            BaseXPath = baseXPath ?? $"//input[@placeholder='{ResHomePage.SearchMenu}']/../../..";
            SearchBoxXPath = $"{BaseXPath}//input[@type='text']";
            SearchItemsXPath = $"{BaseXPath}//a[@role='link']";
        }
    }
}
