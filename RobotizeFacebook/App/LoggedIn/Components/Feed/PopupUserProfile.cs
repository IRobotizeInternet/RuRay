using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PopupUserProfile : BasePopup
    {
        public PopupUserProfile(RemoteWebDriver driver) : base(driver)
        {
        }

        protected override By ByForDialog => throw new System.NotImplementedException();
    }
}