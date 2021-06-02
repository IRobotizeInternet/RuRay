using System;
using OpenQA.Selenium;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class BaseSaveCancelDialog : BaseDialog
    {
        public BaseSaveCancelDialog()
        {
        }

        protected override By ByForDialog => throw new NotImplementedException();

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }

        //public Button ButtonCancel => new Button(Driver, By.XPath($"//span[contains(text(),'{ResSelectPrivacy.Cancel}')]/../../../../.."));
        //public Button ButtonSaveChanges => new Button(Driver, By.XPath($"//span[contains(text(),'{ResSelectPrivacy.SaveChanges}')]/../../../../.."));
    }
}
