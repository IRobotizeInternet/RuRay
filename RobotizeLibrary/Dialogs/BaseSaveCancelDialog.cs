using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeLibrary.CommonControls;
using RobotizeLibrary.Resources;
using System;

namespace RobotizeLibrary.Dialogs
{
    public class BaseSaveCancelDialog : BaseDialog
    {
        public BaseSaveCancelDialog(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        protected override By ByForDialog => throw new NotImplementedException();
        
        public Button ButtonCancel => new Button(Driver, By.XPath($"//span[contains(text(),'{ResSelectPrivacy.Cancel}')]/../../../../.."));
        public Button ButtonSaveChanges => new Button(Driver, By.XPath($"//span[contains(text(),'{ResSelectPrivacy.SaveChanges}')]/../../../../.."));
    }
}
