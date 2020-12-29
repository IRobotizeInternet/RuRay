using System;

namespace RobotizeFacebook.Grid
{
    public interface IColor<TExteriorColor> where TExteriorColor: struct, IConvertible
    {
        IApplyFilter ExteriorColor(TExteriorColor exteriorColor);
    }
}
