using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Dialogs;
using RobotizeFacebook.Resources;

namespace RobotizeFacebook.App.LoggedIn
{
    public class DialogCustomPrivacy : BaseSaveCancelDialog
    {
        public DialogCustomPrivacy(RemoteWebDriver driver) : base(driver)
        {
            BaseXPath = $"//span[text()='{ResSelectPrivacy.CustomPrivacy}']/../../../../..";
        }

        protected override By ByForDialog => By.XPath($"//span[text()='{ResSelectPrivacy.CustomPrivacy}']/../../../../..");

        public Checkbox CheckboxFriendsOfTagged => new Checkbox(Driver, By.XPath($"{BaseXPath}//input[@type='checkbox']"));
        public SearchBoxSharingWithYourFriends ComboboxDontShareWith => 
            new SearchBoxSharingWithYourFriends(Driver, By.XPath($"{BaseXPath}//input[@type='checkbox']"), BaseXPath);
    }
}
