using System;

namespace RobotizeFacebook.Grid
{
    public interface ISortBy<TSortType> where TSortType : struct, IConvertible
    {
        IApplyFilter SortBy(TSortType criteria);
    }
}
