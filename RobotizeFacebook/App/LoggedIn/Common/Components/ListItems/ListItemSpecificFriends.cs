using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Components;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class ListItemSpecificFriends : BaseDiv, IListItem
    {
        public Label LabelFriendName =>
            new Label(Driver, By.XPath($"{BaseXPath}/div[{Index}]/div/div/div/div/div[2]/div/div/div/div[1]/span"));

        public Button ButtonRemoveFromFriendsWhoWontSeeYourPost =>
            new Button(Driver, By.XPath($"{BaseXPath}/div[{Index}]//div[@role='img']"));

        public Button ButtonAddToFriendsWhoWontSeeYourPost =>
            new Button(Driver, By.XPath($"{BaseXPath}/div[{Index}]//div[@role='img']"));
        public int Index { get; set; }

        public ListItemSpecificFriends(string baseXPath, int index = 1)
        {
            Index = index;
            BaseXPath = baseXPath ?? $"//form//div[@aria-label='{ResCreatePost.Friends}']";
        }
    }
}
