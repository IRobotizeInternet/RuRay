using System;

namespace RuRayFacebook.App.LoggedIn
{
    public interface IBathroomsCount<TBathroomsCount> where TBathroomsCount : struct, IConvertible
    {
        IApplyFilter Bedrooms(TBathroomsCount numberOfBedrooms);
    }
}
