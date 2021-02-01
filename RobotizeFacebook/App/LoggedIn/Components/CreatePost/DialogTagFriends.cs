using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.Dialogs;
using System;

namespace RobotizeFacebook.App.LoggedIn.Components
{
    public class DialogTagFriends : BaseDialog
    {
        public DialogTagFriends(RemoteWebDriver driver) : base(driver)
        {
        }

        protected override By ByForDialog => throw new NotImplementedException();
    }
}
