using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
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
