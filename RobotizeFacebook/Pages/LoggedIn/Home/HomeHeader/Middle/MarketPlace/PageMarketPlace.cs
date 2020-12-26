﻿using RobotizeLibrary.Controls;
using RobotizeLibrary.Controls.Grid;

namespace RobotizeFacebook.Pages.LoggedIn.Home.HomeHeader
{
    public class PageMarketPlace : PageBase
    {
        public override string PageUrl => "marketplace";

        public void FilterItem()
        {
            var grid = new FacebookGrid(Driver, Wait);
            grid.ExpandCollapseFilter<IVehicleFilter>("");
        }
    }
}
