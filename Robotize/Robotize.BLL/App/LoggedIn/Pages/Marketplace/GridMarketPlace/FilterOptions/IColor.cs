using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public interface IColor<TExteriorColor> where TExteriorColor: struct, IConvertible
    {
        IApplyFilter ExteriorColor(TExteriorColor exteriorColor);
    }
}
