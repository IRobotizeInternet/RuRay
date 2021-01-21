using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public interface IBedroomsCount<TBedroomCount> where TBedroomCount: struct, IConvertible
    {
        IApplyFilter Bedrooms(TBedroomCount numberOfBedrooms);
    }
}
