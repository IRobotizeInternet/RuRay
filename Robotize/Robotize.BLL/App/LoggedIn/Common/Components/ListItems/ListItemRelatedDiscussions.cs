using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Components;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class ListItemRelatedDiscussions : BaseDiv, IListItem
    {
        public Button LabelSeeWhoReactedToThis => //div[@aria-label='{ResCreatePost.RelatedDiscussions}']
            new Button(Driver, By.XPath($"{BaseXPath}//span[@aria-label='{ResCreatePost.SeeWhoReactedToThis}']/.."));

        public Button EventTriggerButtonComments =>
            new Button(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.Comments}')]"));

        public Button ButtonMoreComments =>
            new Button(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.MoreComments}')]"));

        public EventTriggerButton<DialogPeopleWhoSharedThis> EventTriggerButtonMoreShares =>
           new EventTriggerButton<DialogPeopleWhoSharedThis>(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.MoreShares}')]"));

        public Button ButtonShowAttachment =>
            new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label=\"{ResCreatePost.ShowAttachment}\"]"));

        public EventTriggerButton<DialogPeopleWhoSharedThisMenu> EventTriggerButtonMenu =>
            new EventTriggerButton<DialogPeopleWhoSharedThisMenu>(Driver, By.XPath($"{BaseXPath}//div[@aria-haspopup=\"{ResCreatePost.Menu}\"]"));

        public int XIndex { get; set; }
        public int YIndex { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public ListItemRelatedDiscussions(string baseXPath, int index = 1)
        {
            XIndex = index;
            BaseXPath = baseXPath;
        }
    }
}
