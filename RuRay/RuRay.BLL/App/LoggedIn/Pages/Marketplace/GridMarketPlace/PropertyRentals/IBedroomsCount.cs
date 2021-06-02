using System;

namespace RuRayFacebook.App.LoggedIn
{
    public interface IBedroomsCount<TBedroomCount> where TBedroomCount : struct, IConvertible
    {
        IApplyFilter Bedrooms(TBedroomCount numberOfBedrooms);
    }
}
