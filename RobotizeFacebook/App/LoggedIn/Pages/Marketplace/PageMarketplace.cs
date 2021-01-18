using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RobotizeFacebook.App
{
    public class PageMarketplace : PageBase
    {
        public override string PageUrl => "/marketplace";

        public override By ByForPage => throw new System.NotImplementedException();

        public PageMarketplace(RemoteWebDriver driver)
        {
        }

        public PageMarketplace()
        {

        }

        //public EventTriggerButton<> TriggerButtonCreateNewListing => new EventTriggerButton<EventResult>()
        
    }
}
