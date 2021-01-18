using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public interface IBrand<TBrand> where TBrand : struct, IConvertible
    {
        IApplyFilter Brand(TBrand bodyStyle);
    }
}
