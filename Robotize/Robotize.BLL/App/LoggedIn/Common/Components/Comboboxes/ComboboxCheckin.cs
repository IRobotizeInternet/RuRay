using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public partial class DialogAddVideos
    {
        public class ComboboxCheckin : Combobox
        {
            public ComboboxCheckin(RemoteWebDriver driver, string baseXPath) : base(driver, By.XPath(baseXPath))
            {
                BaseXPath = $"//form[@method='POST']/parent::div[@role='dialog']";
                SearchBoxXPath = $"{BaseXPath}//input[contains(@aria-label,'{ResCreatePost.SearchForVideos}')][@type='text']";
                SearchItemsXPath = $"{BaseXPath}//input[@aria-label='{ResCreatePost.SearchForVideos}']/parent::label/parent::div/parent::div//div[@aria-label='{ResCreatePost.SelectThisCheckbox}']']";
            }
        }
    }
}