using OpenQA.Selenium;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Components;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class ListItemActivity : BaseDiv, IListItem
    {
        public EventTriggerButton<DialogMenu> EventTriggerButtonMenu
            => new EventTriggerButton<DialogMenu>(Driver, By.XPath(""));

        public Label LabelActivity => new Label(Driver, By.XPath($"{BaseXPath}"));

        public ListItemActivity(string baseXPath, int index = 1)
        {
            XIndex = index;
            BaseXPath = baseXPath;
        }

        public int XIndex { get; set; }
        public int YIndex { get; set; }
    }
}
