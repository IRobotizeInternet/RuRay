using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
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
