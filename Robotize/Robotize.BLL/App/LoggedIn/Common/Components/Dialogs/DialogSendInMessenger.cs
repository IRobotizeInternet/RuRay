using System;
using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogSendInMessenger : BaseDialog
    {
        public DialogSendInMessenger()
        {
            BaseXPath = $"//div[@aria-label='{ResHomePage.SendInMessenger}']";
        }

        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResHomePage.SendInMessenger}']");

        public TextBox TextBoxSaySomething => 
            new TextBox(Driver, By.XPath($"//div[@aria-label='{ResHomePage.SaySomethingAboutThis}']"));

        public EventTriggerButton<DialogSendToGroup<DialogSendInMessenger>> EventTriggerButtonSendToGroup => 
            new EventTriggerButton<DialogSendToGroup<DialogSendInMessenger>>(
                Driver, 
                By.XPath($"{BaseXPath}//span[text()='{ResHomePage.SendToNewGroup}']"));


        public ComboboxSharingWithYourFriends ComboboxSearchFriends => 
            new ComboboxSharingWithYourFriends(
                Driver,
                BaseXPath,
                searchItemsXPath: $"{BaseXPath}//div[@aria-label='{ResHomePage.Send}' or @aria-label='{ResHomePage.Sent}']");

        public ScrollControl<ListItemSendInMessenger> ScrollSendInMessenger =>
           new ScrollControl<ListItemSendInMessenger>(
               Driver, 
               $"//form//div[@aria-label='{ResCreatePost.Friends}']/div",
               scrollXPath: $"{BaseXPath}//div[@data-visualcompletion='ignore-dynamic' and ./descendant-or-self::div//span[text()='{ResHomePage.Send}']]");

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
