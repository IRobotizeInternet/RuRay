using System;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface ISortBy<TSortType> where TSortType : struct, IConvertible
    {
        IApplyFilter SortBy(TSortType criteria);
    }
}
