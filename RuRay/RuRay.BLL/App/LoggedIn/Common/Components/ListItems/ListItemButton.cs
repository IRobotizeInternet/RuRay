using OpenQA.Selenium;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Components;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class ListItemButton : BaseDiv, IListItem
    {
        public Label LabelActivity => new Label(Driver, By.XPath($"{BaseXPath}[{XIndex}]"));

        public ListItemButton(string baseXPath, int index = 1)
        {
            XIndex = index;
            BaseXPath = baseXPath;
        }

        public int XIndex { get; set; }
        public int YIndex { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}
