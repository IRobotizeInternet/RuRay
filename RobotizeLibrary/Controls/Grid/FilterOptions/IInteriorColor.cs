using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeLibrary.Controls.Grid
{
    public interface IInteriorColor<TInteriorColor> where TInteriorColor: BaseOptionItems
    {
        IFilterOptions InteriorColor(TInteriorColor interiorColor);
    }
}
