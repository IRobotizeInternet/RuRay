﻿using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.Dialogs;
using RobotizeFacebook.Resources;
using System.Collections.Generic;
using RobotizeToolbox.Controls;
using RobotizeToolbox.CommonControls;

namespace RobotizeFacebook.App.LoggedIn
{
    public class DialogSpecificFriends : BaseSaveCancelDialog
    {
        public DialogSpecificFriends(RemoteWebDriver driver) : base(driver)
        {
            BaseXPath = "//form[@method='POST']";
        }

        public ScrollControl ScrollFriendsExcepts => new ScrollControl(Driver, $"//form//div[@aria-label='{ResCreatePost.Friends}']/div");

        protected override By ByForDialog => By.XPath($"//form[@method='POST']//span[text()='{ResCreatePost.SpecificFriends}']");

        public SearchBoxSharingWithYourFriends ComboboxSearchFriends => new SearchBoxSharingWithYourFriends(Driver, ByForDialog, BaseXPath);

        public IEnumerable<IWebElement> FriendsWhoWontSeeYourPost =>
             Driver.FindElements(By.XPath($"//form[@method='POST']//div[@role='grid'][contains(@aria-label, '{ResCreatePost.FriendsWhoWillSeeYourPost}')]//div[@role='button']"));

        public EventTriggerButton<DialogCreatePost> TriggerSaveChangesButton =>
            new EventTriggerButton<DialogCreatePost>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.SaveChanges}']"));

        public EventTriggerButton<DialogCreatePost> TriggerCancelChangesButton =>
            new EventTriggerButton<DialogCreatePost>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.Cancel}']"));
    }
}
