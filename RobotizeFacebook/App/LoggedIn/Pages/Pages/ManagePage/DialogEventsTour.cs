using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.App.LoggedIn.Pages.Pages.ManagePage
{
    public class DialogEventsTour : BaseDialog
    {
        public DialogEventsTour(RemoteWebDriver driver) : base(driver)
        {
            BaseXPath = $"//div[@aria-label='{ResMiscellaneous.welcomeToEventsAdminTool}'][@role='dialog']";
        }

        protected override By ByForDialog => By.XPath(BaseXPath);

        public Button ButtonTakeTour => new Button(Driver, By.XPath($"//div[@data-hover='tooltip'][text()='{ResMiscellaneous.TakeTour}']"));
        public Button ButtonCloseDialog => new Button(Driver, By.XPath($"{BaseXPath}/div/div/div/div/div[2]//i"));
    }
}
