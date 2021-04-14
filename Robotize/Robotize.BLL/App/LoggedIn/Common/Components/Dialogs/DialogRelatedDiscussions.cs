using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogRelatedDiscussions : BaseDialog
    {
        public DialogRelatedDiscussions(string baseXPath)
        {
        }

        public ScrollControl<ListItemPeopleWhoSharedThis> ScrollPeopleWhoSharedThis =>
           new ScrollControl<ListItemPeopleWhoSharedThis>(
               Driver, 
               $"//div[@aria-label='{ResHomePage.PeopleWhoSharedThis}']/div[3]/div/div/div",
               scrollXPath: $"//div[@aria-label='{ResHomePage.PeopleWhoSharedThis}']/div[3]");

        protected override By ByForDialog => throw new System.NotImplementedException();

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}