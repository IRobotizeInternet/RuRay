using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Resources;
using RobotizeLibrary.Extensions;
using RobotizeToolbox.Dialogs;
namespace RobotizeFacebook.Pages.LoggedIn
{
    public class DialogActivityLogFilter : BaseDialog
    {
        public DialogActivityLogFilter(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {

        }

        protected override By ByForDialog => By.XPath($"//div[@role='dialog'][@aria-label='{ResMiscellaneous.Filter}']");

        public DropdownYear DropdownForYear => new DropdownYear(Driver, new ExtendBy("//div[@aria-haspopup='listbox'][@role='combobox']"));
    }
}
