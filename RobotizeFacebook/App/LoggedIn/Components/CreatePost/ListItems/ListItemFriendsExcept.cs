using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Components;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class ListItemFriendsExcept : BaseDiv, IListItem
    {
        public Label LabelFriendName =>
            new Label(Driver, By.XPath($"//form//div[@aria-label='{ResCreatePost.Friends}']/div[1]//div[@class='']/div/div/span"));

        public Button ButtonRemoveFromFriendsWhoWontSeeYourPost =>
            new Button(Driver, By.XPath($"//form//div[@aria-label=\"{ResCreatePost.RemoveFromFriendsWhoWontSeeYourPost}\"]"));

        public Button ButtonAddToFriendsWhoWontSeeYourPost =>
            new Button(Driver, By.XPath($"//form//div[@aria-label=\"{ResCreatePost.AddToFriendsWhoWontSeeYourPost}\"]"));

        public int Index { get; set; }

        public ListItemFriendsExcept(string baseXPath, int index = 1)
        {
            Index = index;
            BaseXPath = baseXPath;
        }
    }
}
