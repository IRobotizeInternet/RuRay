using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class ComboBoxCategories : Combobox
    {
        public ComboBoxCategories(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
        {
            BaseXPath = $"//div[@role='main']";
            SearchBoxXPath = $"{BaseXPath}//span[text()='{ResLeftNav.Categories}']/parent::div/input";
            SearchItemsXPath = $"//ul[@role='presentation']";
        }
    }
}
