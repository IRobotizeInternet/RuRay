using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeFacebook.Grid
{
    public interface ISortBy<TSortType> where TSortType : struct, IConvertible
    {
        IApplyFilter SortBy(TSortType criteria);
    }
}
