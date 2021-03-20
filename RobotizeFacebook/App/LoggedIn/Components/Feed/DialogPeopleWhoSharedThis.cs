using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogPeopleWhoSharedThis : BaseDriver
    {
        public ScrollControl ScrollReactions =>
           new ScrollControl(Driver, By.XPath($"//div[@aria-label='{ResHomePage.PeopleWhoSharedThis}']/div[3]/div/div/div"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}