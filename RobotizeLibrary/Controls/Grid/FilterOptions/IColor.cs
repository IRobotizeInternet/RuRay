using System;

namespace RobotizeLibrary.Controls.Grid
{
    public interface IColor<TExteriorColor> where TExteriorColor: struct, IConvertible
    {
        IApplyFilter ExteriorColor(TExteriorColor exteriorColor);
    }
}
