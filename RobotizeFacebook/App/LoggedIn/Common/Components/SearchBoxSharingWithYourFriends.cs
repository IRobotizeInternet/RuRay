﻿using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Extensions;
using System;
using System.Threading;

namespace RobotizeFacebook.App.LoggedIn
{
    public class SearchBoxSharingWithYourFriends : Combobox
    {
        public SearchBoxSharingWithYourFriends(
            RemoteWebDriver driver, 
            By byForElement, 
            string baseXPath,
            string searchBoxXPath = null,
            string searchItemsXPath = null) : base(driver, byForElement)
        {
            BaseXPath = baseXPath;
            SearchBoxXPath = searchBoxXPath ?? $"{BaseXPath}//input[@type='search' and contains(@role, 'textbox')]";
            SearchItemsXPath = searchItemsXPath ?? $"{BaseXPath}//div[contains(@role, 'grid')]//div[@role='row']//div[@role='button']";
        }

        public override void Select(string itemToSearch)
        {
            SearchItem(itemToSearch);
            WaitUntilSearchedItemsRetrieved();
            var targetItem = SelectItem(itemToSearch);
            targetItem?.Click();
        }

        private void WaitUntilSearchedItemsRetrieved()
        {
            var byForLoadingSvg = $"//*[name()='svg']//*[name()='circle'][@stroke='var(--progress-ring-disabled-foreground)']";
            Driver.WaitUntilElementDisappears(By.XPath(byForLoadingSvg));
            Thread.Sleep(TimeSpan.FromMilliseconds(500));
        }
    }
}