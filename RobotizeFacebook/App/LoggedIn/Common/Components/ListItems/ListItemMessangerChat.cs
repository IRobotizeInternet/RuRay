using OpenQA.Selenium;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Components;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class ListItemMessangerChat : BaseDiv, IListItem
    {
        public EventTriggerButton<DialogMenu> EventTriggerButtonMenu
            => new EventTriggerButton<DialogMenu>(Driver, By.XPath(""));

        public Label LabelActivity => new Label(Driver, By.XPath($"{BaseXPath}"));

        public ListItemMessangerChat(string baseXPath, int index = 1)
        {
            Index = index;
            BaseXPath = baseXPath;
        }

        public int Index { get; set; }
    }
}
