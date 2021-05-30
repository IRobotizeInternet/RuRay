using System;

namespace RuRayFacebook.App.LoggedIn
{
    public interface IBrand<TBrand> where TBrand : struct, IConvertible
    {
        IApplyFilter Brand(TBrand bodyStyle);
    }
}
