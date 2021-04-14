using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class MenuItemsPageSettings : MenuItems
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
}
