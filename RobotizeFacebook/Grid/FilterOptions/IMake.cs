using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeFacebook.Grid
{
    public interface IMake<TMake> where TMake : struct, IConvertible
    {
        IApplyFilter SortBy(TMake criteria);
    }
}
