using System;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IBrand<TBrand> where TBrand : struct, IConvertible
    {
        IApplyFilter Brand(TBrand bodyStyle);
    }
}
