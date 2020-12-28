using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeLibrary.Controls;
using RobotizeLibrary.Dialogs;
using RobotizeLibrary.Resources;

namespace RobotizeFacebook.Pages.LoggedIn.Dialogs
{
    public class DialogAllKeyboardShortcuts : BaseDialog
    {
        public DialogAllKeyboardShortcuts(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        private readonly string _baseXPath = $"//span[text()='{ResAccount.AllKeyboardShortcuts}']/../../../../..";
        protected override By ByForDialog => By.XPath(_baseXPath);

        public Checkbox SingleCharacterKeyboardShortCut => new Checkbox(Driver, By.XPath($"{_baseXPath}//input[@type='checkbox']"));
    }
}
