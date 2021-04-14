using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogChooseAGIF : BaseDialog
    {
        public DialogChooseAGIF() 
        {
        }

        //public ScrollControl ScrollGIF =>
        //   new ScrollControl(Driver, $"//form[descendant::input[@aria-label='{ResCreatePost.GIFSearch}']]//img[@alt='GIF']");//form[@method='POST']/parent::div[@role='dialog']/form/div/div[2]/div/div[2]/div/div[2]/div/div/div"));

        protected override By ByForDialog => By.XPath($"//form[@method='POST']/parent::div[@role='dialog']//span[text()='{ResCreatePost.ChooseAGIF}']");

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

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