using System;

namespace RobotizeFacebook.Grid
{
    public interface IMake<TMake> where TMake : struct, IConvertible
    {
        IApplyFilter SortBy(TMake criteria);
    }
}
