using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
