using System;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IBedroomsCount<TBedroomCount> where TBedroomCount: struct, IConvertible
    {
        IApplyFilter Bedrooms(TBedroomCount numberOfBedrooms);
    }
}
