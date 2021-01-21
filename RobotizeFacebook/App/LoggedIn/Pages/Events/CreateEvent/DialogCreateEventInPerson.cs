using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.Dialogs;
using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogCreateEventInPerson : BaseDialog
    {
        public DialogCreateEventInPerson(RemoteWebDriver driver) : base(driver)
        {
        }

        protected override By ByForDialog => throw new NotImplementedException();
    }
}
