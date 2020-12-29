using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeLibrary.Extensions;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Extensions;
using System;
using System.Linq;
using System.Threading;

namespace RobotizeToolbox.Controls
{
    public class Combobox : BaseDOMProperty, IDropdownElement
    {
        protected By ByForSearchbox;
        
        public Combobox(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
        {
            var searchboxXPath = $"{((ExtendBy)byForElement).GetDescription()}//input[@type='search' and contains(@role, 'textbox')]";
            ByForSearchbox = By.XPath(searchboxXPath);
            ScrollToElement(Driver.FindVisibleElementsWait(ByForSearchbox).First());
        }

        private void SetItem(string value)
        {
            var searchTextbox = new TextBox(Driver, ByForSearchbox);

            // clear existing values before setting new values. 
            searchTextbox.Clear();

            searchTextbox.SetData(value);
        }

        public void Select(string itemToSearch)
        {
            //return when item to search value is empty
            if (string.IsNullOrWhiteSpace(itemToSearch)) return;

            // Enter the search string, then wait for items to load
            SetItem(itemToSearch);
            WaitUntilComboboxLoading();
            Thread.Sleep(TimeSpan.FromMilliseconds(500));

            var itemsElementXPath = "//form[@method='POST']//div[contains(@role, 'grid')]//div[@role='row']";
            var items = Driver.FindElements(By.XPath(itemsElementXPath));
            var targetItems = items.Where(x => x.Text == itemToSearch);
            
            if (targetItems.Count() != 0)
            {
                throw new NoSuchElementException($"Element {itemToSearch} in combobox {ByForSearchbox} no found.");
            }

            targetItems.First()?.Click();
        }

        private void WaitUntilComboboxLoading()
        {
            var wait = new DefaultWait<By>(ByForElement)
            {
                PollingInterval = TimeSpan.FromMilliseconds(100),
                Timeout = TimeSpan.FromSeconds(60)
            };

            wait.Until(byForElement =>
            {
                try
                {
                    var byForLoadingSvg = $"//*[name()='svg']//*[name()='circle'][@stroke='var(--progress-ring-disabled-foreground)']";
                    return Driver.FindVisibleElementsWait(By.XPath(byForLoadingSvg)).Count() == 0;
                }
                catch (ElementNotVisibleException ex)
                {
                    Console.WriteLine($"{nameof(WaitUntilComboboxLoading)} is errored out {ex.Message}");
                    return false;
                }
            });
        }
    }
}