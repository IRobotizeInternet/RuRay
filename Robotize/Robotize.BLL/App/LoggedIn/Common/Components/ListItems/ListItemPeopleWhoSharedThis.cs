using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Components;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class ListItemPeopleWhoSharedThis : BaseDiv, IListItem
    {
        public Label LabelUserName =>
            new Label(Driver, By.XPath($"{BaseXPath}[{XIndex}]//strong/span"));

        public EventTriggerButton<HoverOverUserProfile> EventTriggerButtonUserName =>
            new EventTriggerButton<HoverOverUserProfile>(Driver, By.XPath($"{BaseXPath}[{XIndex}]//strong/span"));

        public EventTriggerButton<HoverOverLike> ButtonLike =>
           new EventTriggerButton<HoverOverLike>(Driver, By.XPath($"{BaseXPath}[{XIndex}]{Constants.LikeOptions}"));

        public Button ButtonSendThisToFriendsOrPostItOnYourTimeline =>
            new Button(Driver, By.XPath($"{BaseXPath}{XIndex}//div[@aria-label=\"{ResCreatePost.SendThisToFriendsOrPostItOnYourTimeline}\"]"));

        public Button ButtonShowAttachment =>
            new Button(Driver, By.XPath($"{BaseXPath}[{XIndex}]//div[@aria-label=\"{ResCreatePost.ShowAttachment}\"]"));

        public EventTriggerButton<DialogPeopleWhoSharedThisMenu> EventTriggerButtonDotDotDotMenu =>
            new EventTriggerButton<DialogPeopleWhoSharedThisMenu>(Driver, By.XPath($"{BaseXPath}{XIndex}//div[@aria-haspopup=\"{ResCreatePost.Menu}\"]"));

        public EventTriggerButton<DialogShare> EventTriggerButtonShare =>
           new EventTriggerButton<DialogShare>(Driver, By.XPath($"{BaseXPath}{XIndex}//div[@aria-label=\"{ResCreatePost.Share}\"]"));

        public int XIndex { get; set; }
        public int YIndex { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public ListItemPeopleWhoSharedThis(string baseXPath, int index = 1)
        {
            BaseXPath = baseXPath;
            XIndex = index;
        }
    }
}
