using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeToolbox.Controls.TriggerControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
