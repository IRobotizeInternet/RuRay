using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.App.LoggedIn.Dialogs
{
    public class DialogAllKeyboardShortcuts : BaseDialog
    {
        public DialogAllKeyboardShortcuts(RemoteWebDriver driver) : base(driver)
        {
        }

        private readonly string _baseXPath = $"//span[text()='{ResAccount.AllKeyboardShortcuts}']/../../../../..";
        protected override By ByForDialog => By.XPath(_baseXPath);

        public Checkbox SingleCharacterKeyboardShortCut => new Checkbox(Driver, By.XPath($"{_baseXPath}//input[@type='checkbox']"));
    }
}
