using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Components;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class ListItemSpecificFriends : BaseDiv, IListItem
    {
        public Label LabelFriendName =>
            new Label(Driver, By.XPath($"{BaseXPath}//div[@role='gridcell']/div/div/div[2]/div/div/div/div[1]"));

        public Button ButtonRomoveOrAddFriend => new Button(Driver, By.XPath($"{BaseXPath}//li"));

        public Button ButtonRemoveFromFriendsWhoWillSeeYourPost =>
            new Button(Driver, By.XPath($"//form//div[@aria-label=\"{ResCreatePost.RemoveFromFriendsWhoWillSeeYourPost}\"]"));

        public Button ButtonAddToFriendsWhoWillSeeYourPost =>
            new Button(Driver, By.XPath($"//form//div[@aria-label=\"{ResCreatePost.AddToFriendsWhoWillSeeYourPost}\"]"));

        public int Index { get; set; }

        public ListItemSpecificFriends(string baseXPath, int index = 1)
        {
            Index = index;
            BaseXPath = baseXPath ?? $"//form//div[@aria-label='{ResCreatePost.Friends}']" + "/div[{0}]";
        }
    }
}
