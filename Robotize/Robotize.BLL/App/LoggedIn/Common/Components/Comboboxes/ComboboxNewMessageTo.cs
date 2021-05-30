﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Common.Components.Comboboxes
{
    public class ComboboxNewMessageTo  : Combobox
    {
        public ComboboxNewMessageTo(
           RemoteWebDriver driver,
           string baseXPath) : base(driver, By.XPath(baseXPath))
        {
            BaseXPath = baseXPath ?? "//div[@data-pagelet='ChatTab']";
            SearchBoxXPath = $"{BaseXPath}//input[@type='search']";
            SearchItemsXPath = $"{BaseXPath}//ul[@role='listbox']//li[@role='option']";
        }
    }
}
