using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class MenuItemsCreateNewPage : MenuItems
    {
        public TextBox TextboxPagePageName =>
            new TextBox(Driver, By.XPath($"//label[contains(@aria-label,{ResLeftNav.PageName}')]"));
        public TextBox TextboxPageCategory =>
            new TextBox(Driver, By.XPath($"//label[contains(@aria-label, {ResLeftNav.Category}')]"));
        public TextBox TextboxDescription =>
            new TextBox(Driver, By.XPath($"//label[contains(@aria-label, {ResLeftNav.Description}')]"));

        public EventTriggerButton<AfterSaveControls> EventTriggerButtonCreatePage =>
            new EventTriggerButton<AfterSaveControls>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.CreatePage}')]"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }

    public class AfterSaveControls
    {
        private RemoteWebDriver _driver;
        private By _byForAnElement;
        public AfterSaveControls(RemoteWebDriver driver, By byForElement)
        {
            _driver = driver;
            _byForAnElement = byForElement;
        }

        public Button ButtonSave =>
            new Button(_driver, By.XPath($"//span[contains(text(), '{ResLeftNav.Save}')]"));
        public Button ButtonAddCoverPhoto =>
            new Button(_driver, By.XPath($"//span[contains(text(), '{ResLeftNav.AddCoverPhoto}')]"));

        public Button ButtonAddProfilePicture =>
            new Button(_driver, By.XPath($"//span[contains(text(), '{ResLeftNav.AddProfilePicture}')]"));
    }
}
