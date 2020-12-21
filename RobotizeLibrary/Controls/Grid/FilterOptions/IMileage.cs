using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeLibrary.Controls.Grid
{
    public interface IMileage: IFilterOptions
    {
        IApplyFilter Milage(string milage);
    }
}
