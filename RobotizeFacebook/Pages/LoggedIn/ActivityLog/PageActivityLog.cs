using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls.TriggerControls;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class PageActivityLog : PageBase
    {
        public override string PageUrl => "/allactivity/";
        
        public PageActivityLog(RemoteWebDriver driver, WebDriverWait wait)
        {

        }

        public Hyperlink<DialogActivityLogFilter> LinkActivityLogFilter => new Hyperlink<DialogActivityLogFilter>(Driver, Wait, By.XPath($"//div[@role='button']/span[text()='{ResMiscellaneous.Filter}']"));
    }
}
