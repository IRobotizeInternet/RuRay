﻿using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Components;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class ListItemSpecificFriends : BaseDiv, IListItem
    {
        public Label LabelFriendName =>
            new Label(Driver, By.XPath($"{BaseXPath}/div[{XIndex}]/div/div/div/div/div[2]/div/div/div/div[1]/span"));

        public Button ButtonRemoveFromFriendsWhoWontSeeYourPost =>
            new Button(Driver, By.XPath($"{BaseXPath}/div[{XIndex}]//div[@role='img']"));

        public Button ButtonAddToFriendsWhoWontSeeYourPost =>
            new Button(Driver, By.XPath($"{BaseXPath}/div[{XIndex}]//div[@role='img']"));
        public int XIndex { get; set; }
        public int YIndex { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public ListItemSpecificFriends(string baseXPath, int index = 1)
        {
            XIndex = index;
            BaseXPath = baseXPath ?? $"//form//div[@aria-label='{ResCreatePost.Friends}']";
        }
    }
}
