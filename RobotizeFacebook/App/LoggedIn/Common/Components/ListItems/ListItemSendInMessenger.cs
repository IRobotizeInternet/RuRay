using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Components;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class ListItemSendInMessenger : BaseDiv, IListItem
    {
        public Label LabelFriendName =>
            new Label(Driver, By.XPath($"//form//div[@aria-label='{ResCreatePost.Friends}']/div[1]//div[@class='']/div/div/span"));

        public Button ButtonSend =>
            new Button(Driver, By.XPath($"//form//div[@aria-label=\"{ResCreatePost.RemoveFromFriendsWhoWillSeeYourPost}\"]"));

         public int Index { get; set; }

        public ListItemSendInMessenger(string baseXPath, int index = 1)
        {
            Index = index;
            BaseXPath = baseXPath;
        }
    }
}
