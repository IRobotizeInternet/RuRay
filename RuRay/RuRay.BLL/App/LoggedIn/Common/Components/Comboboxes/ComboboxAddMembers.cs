using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;
using RuRayToolbox.Extensions;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="ComboboxAddMembers" />.
    /// </summary>
    public class ComboboxAddMembers : Combobox
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComboboxAddMembers"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        /// <param name="searchBoxXPath">The searchBoxXPath<see cref="string"/>.</param>
        /// <param name="searchItemsXPath">The searchItemsXPath<see cref="string"/>.</param>
        public ComboboxAddMembers(
           RemoteWebDriver driver,
           string baseXPath,
           string searchBoxXPath = null,
           string searchItemsXPath = null) : base(driver, By.XPath(baseXPath))
        {
            BaseXPath = baseXPath ?? $"//div[@aria-label='{ResCreatePost.CreateGroup}']";
            SearchBoxXPath = searchBoxXPath ?? $"{BaseXPath}//input[@type='search' and contains(@role, 'combobox')]";
            SearchItemsXPath = searchItemsXPath ?? $"{BaseXPath}//div[@aria-label='{ResCreatePost.CreateGroup}']//ul[contains(@role, 'listbox')]/li";
        }

        /// <summary>
        /// The Select.
        /// </summary>
        /// <param name="itemToSearch">The itemToSearch<see cref="string"/>.</param>
        public override void Select(string itemToSearch)
        {
            SearchItem(itemToSearch);
            WaitUntilSearchedItemsRetrieved();
            var targetItem = SelectItem(itemToSearch);
            targetItem?.Click();
        }

        /// <summary>
        /// The WaitUntilSearchedItemsRetrieved.
        /// </summary>
        private void WaitUntilSearchedItemsRetrieved()
        {
            var byForLoadingSvg = $"//*[name()='svg']//*[name()='circle'][@stroke='var(--progress-ring-disabled-foreground)']";
            Driver.WaitUntilElementDisappears(By.XPath(byForLoadingSvg));
            Thread.Sleep(TimeSpan.FromMilliseconds(500));
        }
    }
}
