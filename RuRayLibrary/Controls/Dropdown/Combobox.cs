using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace RuRayToolbox.Controls
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

        protected IEnumerable<IWebElement> RetrieveSearchedItems(string itemToSearch)
        {
            SearchedResultElements = Driver.FindElements(By.XPath(SearchItemsXPath));
            return SearchedResultElements.Where(x => x.Text.Contains(itemToSearch));
        }

        protected virtual void WaitUntilComboboxLoading(string xPathForWating = null)
        {
            var byForLoadingSvg = "//div[@aria-busy='false']";
            Driver.FindVisibleElementsWait(By.XPath(byForLoadingSvg));
            Thread.Sleep(TimeSpan.FromMilliseconds(500));
        }
    }
}