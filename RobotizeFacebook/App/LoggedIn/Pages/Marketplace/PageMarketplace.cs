using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PageMarketplace : BasePage
    {
        public override string PageUrl => "/marketplace";

        public override By ByForPage => throw new System.NotImplementedException();

        public PageMarketplace(RemoteWebDriver driver)
        {
        }

        public PageMarketplace()
        {

        }

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

        //public EventTriggerButton<> TriggerButtonCreateNewListing => new EventTriggerButton<EventResult>()

    }
}
