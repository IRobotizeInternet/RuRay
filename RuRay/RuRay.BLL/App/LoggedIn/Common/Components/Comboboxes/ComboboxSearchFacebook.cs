using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="ComboboxMenu" />.
    /// </summary>
    public class ComboboxMenu : Combobox
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComboboxMenu"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        public ComboboxMenu(RemoteWebDriver driver, string baseXPath) : base(driver, By.XPath(baseXPath))
        {
            BaseXPath = baseXPath ?? $"//input[@placeholder='{ResHomePage.SearchMenu}']/../../..";
            SearchBoxXPath = $"{BaseXPath}//input[@type='text']";
            SearchItemsXPath = $"{BaseXPath}//a[@role='link']";
        }
    }
}
