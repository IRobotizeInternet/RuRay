using System;
using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogCreateGroup : BaseDialog
    {
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResHomePage.CreateGroup1}'][@role='dialog']");

        public DialogCreateGroup()
        {
            BaseXPath = $"//div[@aria-label='{ResHomePage.CreateGroup1}'][@role='dialog']";
        }

        public ComboboxAddMembers ComboboxAddMembers => 
            new ComboboxAddMembers(Driver, $"//div[@aria-label='{ResCreatePost.CreateGroup}']");

        public ScrollControl<ListItemButton> ScrollControlUsers =>
            new ScrollControl<ListItemButton>(Driver, $"//div[@aria-label='{ResCreatePost.CreateGroup}']//ul[contains(@role, 'listbox')]/li");

        public EventTriggerButton<PopupNewMessage> EventTriggerButtonCreateGroup =>
            new EventTriggerButton<PopupNewMessage>(Driver, By.XPath($"//div[@aria-label='{ResCreatePost.CreateGroup}']//div[@aria-label='{ResHomePageHeader.Create}']"));

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
