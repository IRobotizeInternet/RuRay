using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using RobotizeFacebook.Resources;
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
        
        public ListItemAddVideo(string baseXPath)
        {
            BaseXPath = baseXPath;
        }
    }
}
