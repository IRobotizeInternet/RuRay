using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogPeopleWhoSharedThis : BaseDriver
    {
        public ScrollControl<ListItemPeopleWhoSharedThis> ScrollReactions =>
           new ScrollControl<ListItemPeopleWhoSharedThis>(Driver, $"//div[@aria-label='{ResHomePage.PeopleWhoSharedThis}']/div[3]/div/div/div");

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}