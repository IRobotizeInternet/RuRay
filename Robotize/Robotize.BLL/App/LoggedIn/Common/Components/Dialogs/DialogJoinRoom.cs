using OpenQA.Selenium;
using Robotize.BLL.Resources;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogJoinRoom : BaseDialog
    {
        public DialogJoinRoom()
        {
        }

        protected override By ByForDialog => By.XPath($"//div[@role='dialog']//span[text()='{ResMiscellaneous.JoinRoom}']");

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
