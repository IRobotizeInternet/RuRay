using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Components;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class ListItemSpecificFriends : BaseDiv, IListItem
    {
        public Label LabelFriendName =>
            new Label(Driver, By.XPath($"//form//div[@aria-label='{ResCreatePost.Friends}']/div[1]//div[@class='']/div/div/span"));

        public Button ButtonRemoveFromFriendsWhoWillSeeYourPost =>
            new Button(Driver, By.XPath($"//form//div[@aria-label=\"{ResCreatePost.RemoveFromFriendsWhoWillSeeYourPost}\"]"));

        public Button ButtonAddToFriendsWhoWillSeeYourPost =>
            new Button(Driver, By.XPath($"//form//div[@aria-label=\"{ResCreatePost.AddToFriendsWhoWillSeeYourPost}\"]"));

        
        public ListItemSpecificFriends(string baseXPath)
        {
            BaseXPath = baseXPath;
        }
    }
}
