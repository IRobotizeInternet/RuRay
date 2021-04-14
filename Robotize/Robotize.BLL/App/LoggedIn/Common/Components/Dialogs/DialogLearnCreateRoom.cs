using OpenQA.Selenium;
using Robotize.BLL.Resources;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogLearnCreateRoom : BaseDialog
    {
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResMiscellaneous.LearnHowRoomsWork}']");

        public DialogLearnCreateRoom()
        {

        }

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
