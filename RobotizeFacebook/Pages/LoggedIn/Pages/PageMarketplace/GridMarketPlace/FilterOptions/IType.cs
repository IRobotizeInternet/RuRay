using System;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IType<TType> where TType : struct, IConvertible
    {
        IFilterOptions VehicleType(TType vehicleType);
    }
}
