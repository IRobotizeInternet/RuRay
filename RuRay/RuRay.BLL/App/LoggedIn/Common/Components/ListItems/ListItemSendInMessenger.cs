using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Components;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class ListItemSendInMessenger : BaseDiv, IListItem
    {
        public Label LabelFriendName =>
            new Label(Driver, By.XPath($"//form//div[@aria-label='{ResCreatePost.Friends}']/div[{XIndex}]//div[@class='']/div/div/span"));

        public Button ButtonSend =>
            new Button(Driver, By.XPath($"//form//div[@aria-label=\"{ResCreatePost.RemoveFromFriendsWhoWillSeeYourPost}\"]"));

         public int XIndex { get; set; }
        public int YIndex { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public ListItemSendInMessenger(string baseXPath, int index = 1)
        {
            XIndex = index;
            BaseXPath = baseXPath;
        }
    }
}
