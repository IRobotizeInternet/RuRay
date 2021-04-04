using OpenQA.Selenium;
using RobotizeFacebook.Resources;
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

        public int Index { get; set; }

        public ListItemRelatedDiscussions(string baseXPath, int index = 1)
        {
            Index = index;
            BaseXPath = baseXPath;
        }
    }

    //public class DialogPeopleWhoSharedThisMenu : BaseDialog
    //{
    //    public DialogPeopleWhoSharedThisMenu()
    //    {
    //    }

    //    public Button ButtonHideAllFrom =>
    //        new Button(Driver, By.XPath($"//div[@role='menuitem']//span[contains(text(),'{ResCreatePost.HideAllFrom}']"));

    //    public Button ButtonUnFollow =>
    //        new Button(Driver, By.XPath($"//div[@role='menuitem']//span[contains(text(),'{ResCreatePost.Unfollow}']"));

    //    public Button ButtonSavePost =>
    //        new Button(Driver, By.XPath($"//div[@role='menuitem']//span[contains(text(),'{ResCreatePost.SavePost}']"));

    //    public Button ButtonEmbed =>
    //        new Button(Driver, By.XPath($"//div[@role='menuitem']//span[contains(text(),'{ResCreatePost.Embed}']"));

    //    public Button ButtonTurnOnNotificationsForThisPost =>
    //        new Button(Driver, By.XPath($"//div[@role='menuitem']//span[contains(text(),'{ResCreatePost.TurnOnNotificationsForThisPost}']"));

    //    protected override By ByForDialog => By.XPath($"//div[@role='menuitem']//span[text()='{ResCreatePost.TurnOnNotificationsForThisPost}']");

    //    public override void RunConformance()
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}
}
