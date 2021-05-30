using System;

namespace RuRayFacebook.App.LoggedIn
{
    public interface IBedSize<TBedSize> where TBedSize : struct, IConvertible
    {
        IFilterOptions BedSize(TBedSize bedSize);
    }
}