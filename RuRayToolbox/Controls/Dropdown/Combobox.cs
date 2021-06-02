using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Extensions;

namespace RuRayToolbox.Controls
{
    /// <summary>
    /// Defines the <see cref="Combobox" />.
    /// </summary>
    public abstract class Combobox : BaseDOMObject, IDropdownElement
    {
        /// <summary>
        /// Defines the BaseXPath.
        /// </summary>
        protected string BaseXPath;

        /// <summary>
        /// Defines the SearchBoxXPath.
        /// </summary>
        protected string SearchBoxXPath;

        /// <summary>
        /// Defines the SearchItemsXPath.
        /// </summary>
        protected string SearchItemsXPath;

        /// <summary>
        /// Defines the SearchboxWebElement.
        /// </summary>
        private IWebElement SearchboxWebElement;

        /// <summary>
        /// Defines the SearchedResultElements.
        /// </summary>
        private IEnumerable<IWebElement> SearchedResultElements;

        /// <summary>
        /// Initializes a new instance of the <see cref="Combobox"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <param name="byForElement">The byForElement<see cref="By"/>.</param>
        public Combobox(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
        {
        }

        /// <summary>
        /// The SearchItem.
        /// </summary>
        /// <param name="value">The value<see cref="string"/>.</param>
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

        /// <summary>
        /// The SelectItem.
        /// </summary>
        /// <param name="itemToSearch">The itemToSearch<see cref="string"/>.</param>
        /// <returns>The <see cref="IWebElement"/>.</returns>
        protected IWebElement SelectItem(string itemToSearch)
        {
            RetrieveSearchedItems(itemToSearch);
            return SearchedResultElements.FirstOrDefault(x => x.Text.Contains(itemToSearch));
        }

        /// <summary>
        /// The Select.
        /// </summary>
        /// <param name="itemToSearch">The itemToSearch<see cref="string"/>.</param>
        public virtual void Select(string itemToSearch)
        {
            SearchItem(itemToSearch);
            var targetItem = SelectItem(itemToSearch);
            targetItem?.Click();
        }

        /// <summary>
        /// The SelectByIndex.
        /// </summary>
        /// <param name="itemToSearch">The itemToSearch<see cref="string"/>.</param>
        /// <param name="index">The index<see cref="int"/>.</param>
        public virtual void SelectByIndex(string itemToSearch, int index)
        {
            SearchItem(itemToSearch);
            var targetItem = SelectItem(itemToSearch);
            targetItem?.Click();
        }

        /// <summary>
        /// The RetrieveSearchedItems.
        /// </summary>
        /// <param name="itemToSearch">The itemToSearch<see cref="string"/>.</param>
        /// <returns>The <see cref="IEnumerable{IWebElement}"/>.</returns>
        protected IEnumerable<IWebElement> RetrieveSearchedItems(string itemToSearch)
        {
            SearchedResultElements = Driver.FindElements(By.XPath(SearchItemsXPath));
            return SearchedResultElements.Where(x => x.Text.Contains(itemToSearch));
        }

        /// <summary>
        /// The SelectSearchedItems.
        /// </summary>
        /// <param name="itemIndex">The itemIndex<see cref="int"/>.</param>
        /// <returns>The <see cref="IWebElement"/>.</returns>
        protected IWebElement SelectSearchedItems(int itemIndex)
        {
            SearchedResultElements = Driver.FindElements(By.XPath(SearchItemsXPath));
            if (!SearchedResultElements.Any() || SearchedResultElements.Count() < itemIndex + 1)
            {
                return null;
            }

            return SearchedResultElements.ToArray()[itemIndex];
        }

        /// <summary>
        /// The WaitUntilComboboxLoading.
        /// </summary>
        /// <param name="xPathForWating">The xPathForWating<see cref="string"/>.</param>
        protected virtual void WaitUntilComboboxLoading(string xPathForWating = null)
        {
            var byForLoadingSvg = "//div[@aria-busy='false']";
            Driver.FindVisibleElementsWait(By.XPath(byForLoadingSvg));
            Thread.Sleep(TimeSpan.FromMilliseconds(500));
        }
    }
}
