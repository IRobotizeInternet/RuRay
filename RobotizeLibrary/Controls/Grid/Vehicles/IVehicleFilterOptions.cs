using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeLibrary.Controls.Grid
{
    public interface IVehicleFilterOptions : 
        IVehicleOptions, 
        IVehicleSort,
        IPrice,
        IVehicleType,
        IYear,
        IVehicleMake,
        IVehicleModel,
        IVehicleBodyStyle,
        IVehicleMilage,
        IVehicleExteriorColor,
        IVehicleInteriorColor,
        IVehicleTransmissionType

    {
    }
}
