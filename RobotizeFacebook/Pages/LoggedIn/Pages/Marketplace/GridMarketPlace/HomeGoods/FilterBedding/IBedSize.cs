using System;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IBedSize<TBedSize> where TBedSize : struct, IConvertible
    {
        IFilterOptions BedSize(TBedSize bedSize);
    }
}