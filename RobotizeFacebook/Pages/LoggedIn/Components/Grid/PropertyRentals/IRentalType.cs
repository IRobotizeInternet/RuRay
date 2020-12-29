using System;

namespace RobotizeFacebook.Grid
{
    public interface IRentalType<TRentalType> where TRentalType : struct, IConvertible
    {
        IApplyFilter RentalType(TRentalType numberOfBedrooms);
    }
}
