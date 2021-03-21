using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.App.LoggedIn.Components
{
    public class DialogAddVideos : BaseDialog
    {
        public DialogAddVideos(RemoteWebDriver driver) : base(driver)
        {
        }

        public ScrollControl ScrollVideos =>
            new ScrollControl(Driver, $"//form//div[descendant::input[@aria-label='{ResCreatePost.SearchForVideos}']]/following-sibling::div[2]/div/div");

        protected override By ByForDialog => By.XPath($"//form[@method='POST']/parent::div[@role='dialog']//span[text()='{ResCreatePost.AddVideos}']");

        public sealed class CheckinCombox : Combobox
        {
            public CheckinCombox(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
            {
                BaseXPath = $"//form[@method='POST']/parent::div[@role='dialog']";
                SearchBoxXPath = $"{BaseXPath}//input[contains(@aria-label,'{ResCreatePost.SearchForVideos}')][@type='text']";
                SearchItemsXPath = $"{BaseXPath}//input[@aria-label='{ResCreatePost.SearchForVideos}']/parent::label/parent::div/parent::div//div[@aria-label='{ResCreatePost.SelectThisCheckbox}']']";
            }
        }
    }
}