using OpenQA.Selenium;
using RuRay.BLL.Resources;

namespace RuRayFacebook.App.LoggedIn.Pages
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
