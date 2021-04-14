using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Extensions;
using System;
using System.Threading;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class ComboboxAddMembers : Combobox
    {
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
