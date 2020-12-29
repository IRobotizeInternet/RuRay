using System;

namespace RobotizeFacebook.Grid
{
    public interface IBathroomsCount<TBathroomsCount> where TBathroomsCount : struct, IConvertible
    {
        IApplyFilter Bedrooms(TBathroomsCount numberOfBedrooms);
    }
}
