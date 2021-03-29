using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.App.LoggedIn.Enum;
using RobotizeFacebook.Resources;
using RobotizeLibrary.Extensions;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Dialogs;
namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogActivityLogFilter : BaseDialog
    {
        public DialogActivityLogFilter(RemoteWebDriver driver) : base(driver)
        {
            BaseXPath = $"//div[@role='dialog'][@aria-label='{ResMiscellaneous.Filter}']";
        }

        protected override By ByForDialog => By.XPath(BaseXPath);

        public DropdownYear DropdownForYear =>
            new DropdownYear(Driver, new ExtendBy("//div[@aria-haspopup='listbox'][@role='combobox']"));

        public RadioButton GetFilterCategoryButton(FilterCategory category)
        {
            var rButton = new RadioButton(Driver, By.XPath($"{BaseXPath}//span[contains(text(), {category})]"));
            // TODO: Fix the below function.
            //rButton.ScrollToElement();
            return rButton;
        }

        public EventTriggerButton<PageActivityLog> ButtonActivityLog => 
            new EventTriggerButton<PageActivityLog>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResMiscellaneous.ClearAll}')]"));
    }
}
