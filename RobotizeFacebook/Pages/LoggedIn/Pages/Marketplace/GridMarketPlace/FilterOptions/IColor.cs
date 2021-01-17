using System;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IColor<TExteriorColor> where TExteriorColor: struct, IConvertible
    {
        IApplyFilter ExteriorColor(TExteriorColor exteriorColor);
    }
}
