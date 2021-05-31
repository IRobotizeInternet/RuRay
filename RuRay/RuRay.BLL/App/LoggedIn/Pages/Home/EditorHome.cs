using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Remote;
using RuRayLibrary.Components.Eidtor;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class EditorHome : Editor<Header, LeftMenuItemsHome, FeedHome>
    {
        public EditorHome(RemoteWebDriver driver) : base(driver)
        {
        }
    }
}
