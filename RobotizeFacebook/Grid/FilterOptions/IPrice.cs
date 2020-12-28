using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeFacebook.Grid
{
    public interface IPrice
    {
        IApplyFilter Price(double? min = null, double? max = null);
    }
}
