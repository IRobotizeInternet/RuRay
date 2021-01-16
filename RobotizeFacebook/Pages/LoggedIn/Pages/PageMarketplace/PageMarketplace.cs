using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace RobotizeFacebook.Pages
{
    public class PageMarketplace : PageBase
    {
        public override string PageUrl => "/marketplace";

        public PageMarketplace(RemoteWebDriver driver, WebDriverWait wait)
        {
        }

        public PageMarketplace()
        {

        }

        //public EventTriggerButton<> TriggerButtonCreateNewListing => new EventTriggerButton<EventResult>()
        
    }
}
