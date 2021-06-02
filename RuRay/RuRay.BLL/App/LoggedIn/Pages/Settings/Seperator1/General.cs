using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRayFacebook.App.LoggedIn.Pages.Bas;
using RuRayToolbox.Controls.TriggerControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="General" />.
    /// </summary>
    public class General : PageSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="General"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        public General(RemoteWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        /// Gets the LinkName.
        /// </summary>
        public Hyperlink<Name> LinkName => new Hyperlink<Name>(Driver, By.XPath("//li[@data-testid='settings_section_name']"));

        /// <summary>
        /// Gets the LinkUserName.
        /// </summary>
        public Hyperlink<UserName> LinkUserName => new Hyperlink<UserName>(Driver, By.XPath("//li[@data-testid='settings_section_username']"));

        /// <summary>
        /// Gets the LinkContactEmail.
        /// </summary>
        public Hyperlink<Contact> LinkContactEmail => new Hyperlink<Contact>(Driver, By.XPath("//li[@data-testid='settings_section_email']"));

        /// <summary>
        /// Gets the LinkAdAccountContact.
        /// </summary>
        public Hyperlink<AdAccount> LinkAdAccountContact => new Hyperlink<AdAccount>(Driver, By.XPath("//li[@data-testid='settings_section_advertising_email']"));

        /// <summary>
        /// Gets the LinkMemorializationSettings.
        /// </summary>
        public Hyperlink<Memorialization> LinkMemorializationSettings => new Hyperlink<Memorialization>(Driver, By.XPath("//li[@data-testid='settings_section_account_management']"));
    }
}
