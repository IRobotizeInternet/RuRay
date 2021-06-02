using System;

namespace RuRayFacebook.App.LoggedIn
{
    public interface IBodyStyle<TBodyStyle> where TBodyStyle : struct, IConvertible
    {
        IApplyFilter BodyStyle(TBodyStyle bodyStyle);
    }
}
