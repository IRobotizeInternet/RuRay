using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeLibrary.Extensions;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace RobotizeToolbox.Controls
{
    public class Combobox : BaseDOMProperty, IDropdownElement
    {
        protected IWebElement SearchboxWebElement;
        
        public Combobox(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
        {
            SearchboxWebElement = Driver
                .FindElement(byForElement)
                .FindElement(By.XPath("//input[@type='search' and contains(@role, 'textbox')]"));
        }

        private void SetItem(string value)
        {
            // clear existing values before setting new values. 
            SearchboxWebElement.Clear();

            SearchboxWebElement.SendKeys(value);
        }

        // Returns flase when itemToSearch does not matches to exactly one element.
        // 
        public bool Select(string itemToSearch, out IEnumerable<IWebElement> friends)
        {
            var isItemSelected = false;
            friends = new List<IWebElement>();

            //return when item to search value is empty
            if (string.IsNullOrWhiteSpace(itemToSearch)) return isItemSelected;

            // Enter the search string, then wait for items to load
            SetItem(itemToSearch);

            // TODO: Need to modify below function currently not worked as expected 
            // WaitUntilComboboxLoading();
            var searhedItems = GetSearchResultItems(itemToSearch);
            isItemSelected = searhedItems.Count() == 1;

            friends = isItemSelected ? friends : searhedItems;

            if(isItemSelected) searhedItems.First().Click();

            return isItemSelected;
        }

        private IEnumerable<IWebElement> GetSearchResultItems(string itemToSearch)
        {
            var itemsElementXPath = "//form[@method='POST']//div[contains(@role, 'grid')]//div[@role='row']//div[@role='button']";
            var items = Driver.FindElements(By.XPath(itemsElementXPath));
            return items.Where(x => x.Text.Contains(itemToSearch));
        }

        private void WaitUntilComboboxLoading()
        {
            var byForLoadingSvg = $"//*[name()='svg']//*[name()='circle'][@stroke='var(--progress-ring-disabled-foreground)']";
            Driver.WaitUntilElementDisappears(By.XPath(byForLoadingSvg));
            Thread.Sleep(TimeSpan.FromMilliseconds(500));
        }
    }
}