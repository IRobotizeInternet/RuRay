using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public interface ISortBy<TSortType> where TSortType : struct, IConvertible
    {
        IApplyFilter SortBy(TSortType criteria);
    }
}
