using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogGIF : BaseDialog
    {
        public DialogGIF(RemoteWebDriver driver) : base(driver)
        {
        }

        public ScrollControl ScrollGIF =>
           new ScrollControl(Driver, $"//form[descendant::input[@aria-label='{ResCreatePost.GIFSearch}']]//img[@alt='GIF']");//form[@method='POST']/parent::div[@role='dialog']/form/div/div[2]/div/div[2]/div/div[2]/div/div/div"));

        protected override By ByForDialog => By.XPath($"//form[@method='POST']/parent::div[@role='dialog']//span[text()='{ResCreatePost.ChooseAGIF}']");

        public sealed class CheckinCombox : Combobox
        {
            public CheckinCombox(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
            {
                BaseXPath = $"//form[@method='POST']/parent::div[@role='dialog']";
                SearchBoxXPath = $"{BaseXPath}//input[contains(@aria-label,'{ResCreatePost.GIFSearch}')][@type='text']";
                SearchItemsXPath = $"{BaseXPath}//div[@aria-label='{ResCreatePost.GIF}']";
            }
        }
    }
}