using System;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IBathroomsCount<TBathroomsCount> where TBathroomsCount : struct, IConvertible
    {
        IApplyFilter Bedrooms(TBathroomsCount numberOfBedrooms);
    }
}
