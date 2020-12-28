using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeFacebook.Grid
{
    public interface ITrailersFilterOptions :
        IFilterOptions,
        IVehicleSort,
        IPrice,
        IYear,
        IVehicleExteriorColor,
        IVehicleInteriorColor
    {
    }
}
