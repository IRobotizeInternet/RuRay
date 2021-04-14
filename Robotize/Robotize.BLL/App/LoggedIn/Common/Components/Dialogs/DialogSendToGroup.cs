using System;
using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogSendToGroup<TGroup> : BaseDialog where TGroup : BaseDialog
    {
        protected override By ByForDialog => By.XPath($"//div[*/h2/span/span[text()='{ResHomePage.SendToGroup}']]");

        public TextBox TextBoxAddMember => new TextBox(Driver, By.XPath($"{BaseXPath}//input"));

        public EventTriggerButton<TGroup> EventTriggerButtonSendToGroup => 
            new EventTriggerButton<TGroup>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.SendToGroup}']"));

        public ScrollControl<ListItemSendToGroup> ScrollControlSendToGroup =>
            new ScrollControl<ListItemSendToGroup>(
                Driver, 
                BaseXPath, 
                scrollXPath: $"//div[*/h2/span/span[text()='{ResHomePage.SendToGroup}']]//" + "ul[{0}]");

        public EventTriggerButton<TGroup> EventTriggerButtonBackArrow =>
            new EventTriggerButton<TGroup>(Driver, null);

        public DialogSendToGroup()
        {
            BaseXPath = $"//div[*/h2/span/span[text()='{ResHomePage.SendToGroup}']]";
        }
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
