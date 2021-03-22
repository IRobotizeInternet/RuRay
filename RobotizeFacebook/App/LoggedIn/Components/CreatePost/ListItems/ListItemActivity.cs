using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class ListItemActivity : BaseDiv
    {
        public EventTriggerButton<DialogMenu> EventTriggerButtonMenu
            => new EventTriggerButton<DialogMenu>(Driver, By.XPath(""));
        public Label LabelActivity(int index) => new Label(Driver, By.XPath($"{BaseXPath}"));
        public ListItemActivity(string baseXPath)
        {
            BaseXPath = baseXPath;
        }
    }

    public class DialogMenu : BaseDialog
    {
        public DialogMenu(RemoteWebDriver driver) : base(driver)
        {
        }

        protected override By ByForDialog => By.XPath("//span[text()='Delete']");
    }
}
