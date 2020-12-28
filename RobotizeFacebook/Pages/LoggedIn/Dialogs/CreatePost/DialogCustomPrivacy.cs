using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeLibrary.Controls;
using RobotizeLibrary.Dialogs;
using RobotizeLibrary.Resources;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class DialogCustomPrivacy : BaseSaveCancelDialog
    {
        public DialogCustomPrivacy(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
            😒
        }

        private readonly string Basepath = $"//span[text()='{ResSelectPrivacy.CustomPrivacy}']/../../../../..";
        protected override By ByForDialog => By.XPath(Basepath);

        public Checkbox CheckboxFriendsOfTagged => new Checkbox(Driver, By.XPath($"{Basepath}//input[@type='checkbox']"));
        public Combobox ComboboxDontShareWith => new Combobox(Driver, By.XPath($"{Basepath}//input[@type='checkbox']"));
    }
}
