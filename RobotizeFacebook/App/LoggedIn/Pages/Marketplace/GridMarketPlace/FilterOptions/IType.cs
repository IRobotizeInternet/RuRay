using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public interface IType<TType> where TType : struct, IConvertible
    {
        IFilterOptions VehicleType(TType vehicleType);
    }
}
