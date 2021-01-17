
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls.TriggerControls;
using RobotizeToolbox.Dialogs;
using RobotizeFacebook.Resources;
using System;

namespace RobotizeFacebook.Pages.LoggedIn.Settings.Tabs.Seperator1.SecurityEditors
{
    public class WhereYouAreLoggedIn : BaseEditor
    {
        public WhereYouAreLoggedIn(RemoteWebDriver driver) : base(driver)
        {
            
        }

        public Hyperlink<DialogSeeMore> LinkSeeMore => new Hyperlink<DialogSeeMore>(Driver, By.XPath($"//span[text()={ResMiscellaneous.SeeMore}]"));
        public Label LabelLogOutOfAllSessions => new Label(Driver, By.XPath($"//span[text()={ResMiscellaneous.LogOutOfAllSessions}]"));
    }

    public class DialogSeeMore : BaseDialog
    {
        public DialogSeeMore(RemoteWebDriver driver) : base(driver)
        {
        }

        protected override By ByForDialog => throw new NotImplementedException();
    }
}
