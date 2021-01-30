using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace RobotizeToolbox.Controls
{
    public abstract class Combobox : BaseDOMProperty, IDropdownElement
    {
        protected string BaseXPath;
        protected string SearchBoxXPath;
        protected string SearchItemsXPath;
        private IWebElement SearchboxWebElement;
        private IEnumerable<IWebElement> SearchedResultElements;

        public Combobox(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
        {
            
        }

        protected void SearchItem(string value)
        {
            WaitUntilComboboxLoading();

            SearchboxWebElement = Driver
               .FindElement(ByForElement)
               .FindElement(By.XPath(SearchBoxXPath));

            // clear existing values before setting new values. 
            SearchboxWebElement.Clear();

            SearchboxWebElement.SendKeys(value);

            WaitUntilComboboxLoading();
        }

        protected IWebElement SelectItem(string itemToSearch)
        {
            RetrieveSearchedItems(itemToSearch);
            return SearchedResultElements.FirstOrDefault(x => x.Text.Contains(itemToSearch));
        }

        public virtual void Select(string itemToSearch)
        {
            SearchItem(itemToSearch);
            var targetItem = SelectItem(itemToSearch);
            targetItem?.Click();
        }

        public virtual void SelectByIndex(string itemToSearch, int index)
        {
            SearchItem(itemToSearch);
            var targetItem = SelectItem(itemToSearch);
            targetItem?.Click();
        }

        protected IEnumerable<IWebElement> RetrieveSearchedItems(string itemToSearch)
        {
            SearchedResultElements = Driver.FindElements(By.XPath(SearchItemsXPath));
            return SearchedResultElements.Where(x => x.Text.Contains(itemToSearch));
        }

        protected IWebElement SelectSearchedItems(int itemIndex)
        {
            SearchedResultElements = Driver.FindElements(By.XPath(SearchItemsXPath));
            if (!SearchedResultElements.Any() || SearchedResultElements.Count() < itemIndex + 1) return null;

            return SearchedResultElements.ToArray()[itemIndex];
        }

        protected virtual void WaitUntilComboboxLoading(string xPathForWating = null)
        {
            var byForLoadingSvg = "//div[@aria-busy='false']";
            Driver.FindVisibleElementsWait(By.XPath(byForLoadingSvg));
            Thread.Sleep(TimeSpan.FromMilliseconds(500));
        }
    }
}