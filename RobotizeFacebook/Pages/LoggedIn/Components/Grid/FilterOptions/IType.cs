using System;

namespace RobotizeFacebook.Grid
{
    public interface IType<TType> where TType : struct, IConvertible
    {
        IFilterOptions VehicleType(TType vehicleType);
    }
}
