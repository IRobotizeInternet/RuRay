using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Common.Components.Comboboxes
{
    public class ComboboxNewMessageTo  : Combobox
    {
        public ComboboxNewMessageTo(
           RemoteWebDriver driver,
           By byForElement) : base(driver, byForElement)
        {
            BaseXPath = "//div[@data-pagelet='ChatTab']";
            SearchBoxXPath = $"{BaseXPath}//input[@type='search']";
            SearchItemsXPath = $"{BaseXPath}//ul[@role='listbox']//li[@role='option']";
        }
    }
}
