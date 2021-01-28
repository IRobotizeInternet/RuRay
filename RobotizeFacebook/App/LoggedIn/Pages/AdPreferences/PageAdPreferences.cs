using OpenQA.Selenium;
using System;

namespace RobotizeFacebook.App
{
    public class PageAdPreferences : PageBase
    {
        public override string PageUrl => "/adpreferences/advertisers/?entry_product=account_settings_menu";

        public override By ByForPage => throw new NotImplementedException();

        public PageAdPreferences()
        {
        }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
