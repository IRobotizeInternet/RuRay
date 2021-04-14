using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using Robotize.BLL.Resources;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PageActivityLog : BasePage
    {
        public override string PageUrl => "/allactivity/";

        public override By ByForPage => throw new System.NotImplementedException();

        //public ScrollControl ScrollActivity =>
        //    new ScrollControl(Driver, "//div[@data-pagelet='page']//*[name()='svg']/parent::div/parent::div/parent::div");

        public readonly string BaseXPath = $"//div[@data-pagelet='page']/div/div[@aria-label='{ResMiscellaneous.ListOfActivityLogItems}'][@role='navigation']";
        public PageActivityLog(RemoteWebDriver driver)
        {
        }

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
