using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="ComboboxSearchFacebook" />.
    /// </summary>
    public class ComboboxSearchFacebook : Combobox
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComboboxSearchFacebook"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        public ComboboxSearchFacebook(RemoteWebDriver driver, string baseXPath) : base(driver, By.XPath(baseXPath))
        {
            BaseXPath = baseXPath ?? $"//input[@role='combobox'][@placeholder='{ResMiscellaneous.SearchFacebook}']/../../../../..";
            SearchBoxXPath = $"{BaseXPath}//input[@type='search']";
            SearchItemsXPath = $"{BaseXPath}//a[@role='presentation']//span[@dir='auto']/span";
        }
    }
}
