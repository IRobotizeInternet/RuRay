
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeLibrary.CommonControls;
using RobotizeLibrary.Controls.TriggerControls;
using RobotizeLibrary.Dialogs;
using RobotizeLibrary.Resources;
using System;

namespace RobotizeFacebook.Pages.LoggedIn.Settings.Tabs.Seperator1.SecurityEditors
{
    public class WhereYouAreLoggedIn : BaseEditor
    {
        public WhereYouAreLoggedIn(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
            
        }

        public Hyperlink<DialogSeeMore> LinkSeeMore => new Hyperlink<DialogSeeMore>(Driver, Wait, By.XPath($"//span[text()={ResMiscellaneous.SeeMore}]"));
        public Label LabelLogOutOfAllSessions => new Label(Driver, By.XPath($"//span[text()={ResMiscellaneous.LogOutOfAllSessions}]"));
    }

    public class DialogSeeMore : DialogBase
    {
        public DialogSeeMore(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        protected override By ByForDialog => throw new NotImplementedException();
    }
}
