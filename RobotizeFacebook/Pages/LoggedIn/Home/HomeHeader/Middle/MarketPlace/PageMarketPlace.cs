using RobotizeLibrary.Controls;
using RobotizeLibrary.Controls.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeFacebook.Pages.LoggedIn.Home.HomeHeader
{
    public class PageMarketPlace : PageBase
    {
        public override string PageUrl => "marketplace";

        public void FilterItem()
        {
            var grid = new FacebookGrid(Driver, Wait);
            grid.ExpandCollapseFilter<IVehicleFilter>("")
               .FilterBy.
                .Price(21)
                .SortBy()
                

        }
    }
}
