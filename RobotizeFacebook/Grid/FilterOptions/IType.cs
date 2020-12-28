using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeFacebook.Grid
{
    public interface IType<TType> where TType : struct, IConvertible
    {
        IFilterOptions VehicleType(TType vehicleType);
    }
}
