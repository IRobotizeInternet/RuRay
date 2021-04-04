using System;
using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PopupNewMessage : BasePopup
    {
        public PopupNewMessage()
        {
            BaseXPath = "//div[@data-pagelet='ChatTab']";
        }
        protected override By ByForDialog => By.XPath("//div[@data-pagelet='ChatTab']");

        public ScrollControl<ListItemMessangerChat> ScrollPeopleWhoSharedThis =>
            new ScrollControl<ListItemMessangerChat>(
                   Driver,
                   $"//div[@data-pagelet='ChatTab']//div[@aria-label='{ResHomePage.Messages}']//div[@role='row']",
                   scrollXPath: $"//div[@data-pagelet='ChatTab']//div[@aria-label='{ResHomePage.Messages}']/../..");

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }

        public ComboboxSharingWithYourFriends ComboboxSearchByNameOrGroup =>
           new ComboboxSharingWithYourFriends(Driver, By.XPath($"{BaseXPath}//input[@type='checkbox']"), BaseXPath);
    }
}
