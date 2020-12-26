using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeLibrary.Dialogs;
using RobotizeLibrary.Resources;

namespace RobotizeFacebook.Pages.LoggedIn.Home.MainSection.SubSections
{
    public class DialogLearnCreateRoom : BaseDialog
    {
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResMiscellaneous.LearnHowRoomsWork}']");

        public DialogLearnCreateRoom(RemoteWebDriver driver, WebDriverWait wait)
            : base(driver, wait)
        {

        }
    }
}
