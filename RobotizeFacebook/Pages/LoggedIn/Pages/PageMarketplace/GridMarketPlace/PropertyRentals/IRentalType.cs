using System;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IRentalType<TRentalType> where TRentalType : struct, IConvertible
    {
        IApplyFilter RentalType(TRentalType numberOfBedrooms);
    }
}
