using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="MenuItemsCreateNewPage" />.
    /// </summary>
    public class MenuItemsCreateNewPage : MenuItems
    {
        /// <summary>
        /// Gets the TextboxPagePageName.
        /// </summary>
        public TextBox TextboxPagePageName =>
            new TextBox(Driver, By.XPath($"//label[contains(@aria-label,{ResLeftNav.PageName}')]"));

        /// <summary>
        /// Gets the TextboxPageCategory.
        /// </summary>
        public TextBox TextboxPageCategory =>
            new TextBox(Driver, By.XPath($"//label[contains(@aria-label, {ResLeftNav.Category}')]"));

        /// <summary>
        /// Gets the TextboxDescription.
        /// </summary>
        public TextBox TextboxDescription =>
            new TextBox(Driver, By.XPath($"//label[contains(@aria-label, {ResLeftNav.Description}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonCreatePage.
        /// </summary>
        public EventTriggerButton<AfterSaveControls> EventTriggerButtonCreatePage =>
            new EventTriggerButton<AfterSaveControls>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.CreatePage}')]"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }

    /// <summary>
    /// Defines the <see cref="AfterSaveControls" />.
    /// </summary>
    public class AfterSaveControls
    {
        /// <summary>
        /// Defines the _driver.
        /// </summary>
        private readonly RemoteWebDriver _driver;

        /// <summary>
        /// Defines the _byForAnElement.
        /// </summary>
        private readonly By _byForAnElement;

        /// <summary>
        /// Initializes a new instance of the <see cref="AfterSaveControls"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <param name="byForElement">The byForElement<see cref="By"/>.</param>
        public AfterSaveControls(RemoteWebDriver driver, By byForElement)
        {
            _driver = driver;
            _byForAnElement = byForElement;
        }

        /// <summary>
        /// Gets the ButtonSave.
        /// </summary>
        public Button ButtonSave =>
            new Button(_driver, By.XPath($"//span[contains(text(), '{ResLeftNav.Save}')]"));

        /// <summary>
        /// Gets the ButtonAddCoverPhoto.
        /// </summary>
        public Button ButtonAddCoverPhoto =>
            new Button(_driver, By.XPath($"//span[contains(text(), '{ResLeftNav.AddCoverPhoto}')]"));

        /// <summary>
        /// Gets the ButtonAddProfilePicture.
        /// </summary>
        public Button ButtonAddProfilePicture =>
            new Button(_driver, By.XPath($"//span[contains(text(), '{ResLeftNav.AddProfilePicture}')]"));
    }
}
