using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.Dialogs;
using RobotizeFacebook.Resources;

namespace RobotizeFacebook.App.LoggedIn.Home.MainSection.SubSections
{
    public class DialogLearnCreateRoom : BaseDialog
    {
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResMiscellaneous.LearnHowRoomsWork}']");

        public DialogLearnCreateRoom(RemoteWebDriver driver)
            : base(driver)
        {

        }
    }
}
