using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Components;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class ListItemMessangerChat : BaseDiv, IListItem
    {
        public EventTriggerButton<DialogMenu> EventTriggerButtonMenu
            => new EventTriggerButton<DialogMenu>(Driver, By.XPath($"{BaseXPath}/div[{XIndex}"));

        public Label LabelMessage => new Label(Driver, By.XPath($"{BaseXPath}/div[{XIndex}]//div[@data-scope='messages_table']//div[@data-testid='outgoing_message']"));

        public Label LabelHoverOver => new Label(Driver, By.XPath($"{BaseXPath}/div[{XIndex}]//div[@data-scope='messages_table']//div[@aria-label={ResHomePage.MessageActions}]"));

        public ListItemMessangerChat(string baseXPath, int xIndex = 1, int yIndex = 1)
        {
            XIndex = xIndex;
            YIndex = yIndex;
            BaseXPath = baseXPath ?? $"//div[@data-pagelet = 'ChatTab']//div[@aria-label='{ResHomePage.Messages}']";
        }

        public int XIndex { get; set; }
        public int YIndex { get; set; }
    }

    public class PopupMessageActions : BasePopup
    {
        protected override By ByForDialog => By.XPath($"//div[@data-pagelet = 'ChatTab']//div[@aria-label='{ResHomePage.Messages}']//div[@aria-label='{ResHomePage.Reply}']");

        // TODO: Clicking this message should take the user to Popup new Message window and place the cursor into the textbox chat box.
        public EventTriggerButton<PopupNewMessage> EventTriggerButton =>
            new EventTriggerButton<PopupNewMessage>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.Reply}']"));

        public PopupMessageActions()
        {
            BaseXPath = $"//div[@data-pagelet = 'ChatTab']//div[@aria-label='{ResHomePage.Messages}']";
        }
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
