using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.Dialogs;
using System;

namespace RobotizeFacebook.App.LoggedIn.Pages.Events.CreateEvent
{
    public class DialogCreateEventOnline : BaseDialog
    {
        public DialogCreateEventOnline(RemoteWebDriver driver) : base(driver)
        {
        }

        protected override By ByForDialog => throw new NotImplementedException();
    }
}
