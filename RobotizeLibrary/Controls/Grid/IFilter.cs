using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeLibrary.Controls.Grid
{
    public interface IFilter<out TFilterOptions> where TFilterOptions : IFilterOptions
    {
        void ClearFilter();
        TFilterOptions FilterBy { get; }
    }
}
