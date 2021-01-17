using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;

namespace RobotizeToolbox.Dialogs
{
    public class BaseSaveCancelDialog : BaseDialog
    {
        public BaseSaveCancelDialog(RemoteWebDriver driver) : base(driver)
        {
        }

        protected override By ByForDialog => throw new NotImplementedException();
        
        //public Button ButtonCancel => new Button(Driver, By.XPath($"//span[contains(text(),'{ResSelectPrivacy.Cancel}')]/../../../../.."));
        //public Button ButtonSaveChanges => new Button(Driver, By.XPath($"//span[contains(text(),'{ResSelectPrivacy.SaveChanges}')]/../../../../.."));
    }
}
