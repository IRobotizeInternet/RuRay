using OpenQA.Selenium;
using Robotize.BLL.Resources;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogLifeEvents : BaseDialog
    {
        public DialogLifeEvents()
        {
            
        }

        protected override By ByForDialog => By.XPath($"//span[text()='{ResHomePage.LifeEvent}']");

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
