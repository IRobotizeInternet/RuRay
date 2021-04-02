using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Components;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class ListItemPeopleWhoSharedThis : BaseDiv, IListItem
    {
        public Label LabelUserName =>
            new Label(Driver, By.XPath($"{BaseXPath}//strong/span"));

        public Button ButtonLike =>
            new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.Like}']"));

        public Button ButtonSendThisToFriendsOrPostItOnYourTimeline =>
            new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label=\"{ResCreatePost.SendThisToFriendsOrPostItOnYourTimeline}\"]"));

        public Button ButtonShowAttachment =>
            new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label=\"{ResCreatePost.ShowAttachment}\"]"));

        public EventTriggerButton<DialogPeopleWhoSharedThisMenu> EventTriggerButtonMenu =>
            new EventTriggerButton<DialogPeopleWhoSharedThisMenu>(Driver, By.XPath($"{BaseXPath}//div[@aria-haspopup=\"{ResCreatePost.Menu}\"]"));
        
        public ListItemPeopleWhoSharedThis(string baseXPath)
        {
            BaseXPath = baseXPath;
        }
    }

    public class DialogPeopleWhoSharedThisMenu : BaseDialog
    {
        public DialogPeopleWhoSharedThisMenu()
        {
        }

        public Button ButtonHideAllFrom =>
            new Button(Driver, By.XPath($"//div[@role='menuitem']//span[contains(text(),'{ResCreatePost.HideAllFrom}']"));

        public Button ButtonUnFollow =>
            new Button(Driver, By.XPath($"//div[@role='menuitem']//span[contains(text(),'{ResCreatePost.Unfollow}']"));

        public Button ButtonSavePost =>
            new Button(Driver, By.XPath($"//div[@role='menuitem']//span[contains(text(),'{ResCreatePost.SavePost}']"));

        public Button ButtonEmbed =>
            new Button(Driver, By.XPath($"//div[@role='menuitem']//span[contains(text(),'{ResCreatePost.Embed}']"));

        public Button ButtonTurnOnNotificationsForThisPost =>
            new Button(Driver, By.XPath($"//div[@role='menuitem']//span[contains(text(),'{ResCreatePost.TurnOnNotificationsForThisPost}']"));

        protected override By ByForDialog => By.XPath($"//div[@role='menuitem']//span[text()='{ResCreatePost.TurnOnNotificationsForThisPost}']");

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
