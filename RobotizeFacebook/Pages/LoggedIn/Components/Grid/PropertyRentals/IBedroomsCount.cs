using System;

namespace RobotizeFacebook.Grid
{
    public interface IBedroomsCount<TBedroomCount> where TBedroomCount: struct, IConvertible
    {
        IApplyFilter Bedrooms(TBedroomCount numberOfBedrooms);
    }
}
