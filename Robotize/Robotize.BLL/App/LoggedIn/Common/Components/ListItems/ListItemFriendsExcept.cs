using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Components;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class ListItemFriendsExcept : BaseDiv, IListItem
    {
        public Label LabelFriendName =>
            new Label(Driver, By.XPath($"{BaseXPath}/div[{XIndex}]/div/div/div/div/div[2]/div/div/div/div[1]/span"));

        public Button ButtonRemoveFromFriendsWhoWontSeeYourPost =>
           new Button(Driver, By.XPath($"{BaseXPath}/div[{XIndex}]//div[@role='img']"));

        public Button ButtonAddToFriendsWhoWontSeeYourPost =>
            new Button(Driver, By.XPath($"{BaseXPath}/div[{XIndex}]//div[@role='img']"));

        public int XIndex { get; set; }
        public int YIndex { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public ListItemFriendsExcept(string baseXPath, int index = 1)
        {
            XIndex = index;
            BaseXPath = baseXPath ?? $"//form//div[@aria-label='{ResCreatePost.Friends}']"; ;
        }
    }
}
