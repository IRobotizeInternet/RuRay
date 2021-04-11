using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public interface IRentalType<TRentalType> where TRentalType : struct, IConvertible
    {
        IApplyFilter RentalType(TRentalType numberOfBedrooms);
    }
}
