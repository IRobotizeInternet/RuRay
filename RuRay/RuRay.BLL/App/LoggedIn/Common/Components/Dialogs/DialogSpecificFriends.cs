using OpenQA.Selenium;
using RuRay.BLL.Resources;
using System.Collections.Generic;
using RuRayToolbox.Controls;
using RuRayToolbox.CommonControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class DialogSpecificFriends : BaseSaveCancelDialog
    {
        public DialogSpecificFriends()
        {
            BaseXPath = $"//form[@method='POST']//div[./div/div/h2/span/span[text()='{ResCreatePost.SpecificFriends}']]";
        }

        public ScrollControl<ListItemSpecificFriends> ScrollFriendsExcepts => 
            new ScrollControl<ListItemSpecificFriends>(Driver, $"//form//div[@aria-label='{ResCreatePost.Friends}']/div");

        protected override By ByForDialog => By.XPath($"//form[@method='POST']//span[text()='{ResCreatePost.SpecificFriends}']");

        public ComboboxSharingWithYourFriends ComboboxSearchFriends => new ComboboxSharingWithYourFriends(Driver, BaseXPath);

        public IEnumerable<IWebElement> FriendsWhoWontSeeYourPost =>
             Driver.FindElements(By.XPath($"//form[@method='POST']//div[@role='grid'][contains(@aria-label, '{ResCreatePost.FriendsWhoWillSeeYourPost}')]//div[@role='button']"));

        public EventTriggerButton<DialogCreatePost> TriggerSaveChangesButton =>
            new EventTriggerButton<DialogCreatePost>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.SaveChanges}']"));

        public EventTriggerButton<DialogCreatePost> TriggerCancelChangesButton =>
            new EventTriggerButton<DialogCreatePost>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.Cancel}']"));
    }
}
