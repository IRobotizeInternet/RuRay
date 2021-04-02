using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogPeopleWhoSharedThis : BaseDriver
    {
        public ScrollControl<ListItemPeopleWhoSharedThis> ScrollPeopleWhoSharedThis =>
           new ScrollControl<ListItemPeopleWhoSharedThis>(
               Driver, 
               $"//div[@aria-label='{ResHomePage.PeopleWhoSharedThis}']/div[3]/div/div/div",
               scrollXPath: $"//div[@aria-label='{ResHomePage.PeopleWhoSharedThis}']/div[3]");

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}