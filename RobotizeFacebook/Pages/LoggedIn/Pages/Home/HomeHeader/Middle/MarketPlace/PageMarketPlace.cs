using OpenQA.Selenium;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.Pages.LoggedIn.Home.HomeHeader
{
    public class PageMarketPlace : PageBase
    {
        public override string PageUrl => "marketplace";

        public override By ByForPage => throw new System.NotImplementedException();

        public void FilterItem()
        {
            var grid = new FacebookGrid(Driver);
            grid.ExpandCollapseFilter<IVehicleFilter>("");
        }
    }
}
