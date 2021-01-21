using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogCommerceProfile : BaseDialog
    {
        public DialogCommerceProfile(RemoteWebDriver driver) : base(driver)
        {
        }

        protected override By ByForDialog => throw new NotImplementedException();
    }
}
