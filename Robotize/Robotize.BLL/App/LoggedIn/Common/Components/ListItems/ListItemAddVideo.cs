using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Components;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class ListItemAddVideo : BaseDiv, IListItem
    {
        public Label LabelMovieTitle => 
            new Label(Driver, By.XPath($"{BaseXPath}//img/parent::div/following-sibling::div/div/span/span"));

        public Label LabelMovieViews =>
            new Label(Driver, By.XPath($"{BaseXPath}//img/parent::div/following-sibling::div/span"));

        public Checkbox CheckboxSelectThisCheckbox =>
            new Checkbox(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.SelectThisCheckbox}']"));
        
        public int XIndex { get; set; }
        public int YIndex { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public ListItemAddVideo(string baseXPath, int index = 1)
        {
            XIndex = index;
            BaseXPath = baseXPath;
        }
    }
}
