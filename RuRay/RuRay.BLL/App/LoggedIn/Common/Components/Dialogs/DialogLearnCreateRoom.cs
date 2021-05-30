using OpenQA.Selenium;
using RuRay.BLL.Resources;

namespace RuRayFacebook.App.LoggedIn.Pages
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
