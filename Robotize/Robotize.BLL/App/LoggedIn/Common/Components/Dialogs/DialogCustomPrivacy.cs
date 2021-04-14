using OpenQA.Selenium;
using RobotizeToolbox.Controls;
using Robotize.BLL.Resources;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogCustomPrivacy : BaseSaveCancelDialog
    {
        public DialogCustomPrivacy()
        {
            BaseXPath = $"//span[text()='{ResSelectPrivacy.CustomPrivacy}']/../../../../..";
        }

        protected override By ByForDialog => By.XPath($"//span[text()='{ResSelectPrivacy.CustomPrivacy}']/../../../../..");

        public Checkbox CheckboxFriendsOfTagged => new Checkbox(Driver, By.XPath($"{BaseXPath}//input[@type='checkbox']"));
        public ComboboxSharingWithYourFriends ComboboxDontShareWith => 
            new ComboboxSharingWithYourFriends(Driver, BaseXPath);
    }
}
