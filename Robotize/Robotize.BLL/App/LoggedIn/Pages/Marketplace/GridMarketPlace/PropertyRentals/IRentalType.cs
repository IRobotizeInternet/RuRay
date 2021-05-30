using System;

namespace RuRayFacebook.App.LoggedIn
{
    public interface IRentalType<TRentalType> where TRentalType : struct, IConvertible
    {
        IApplyFilter RentalType(TRentalType numberOfBedrooms);
    }
}
