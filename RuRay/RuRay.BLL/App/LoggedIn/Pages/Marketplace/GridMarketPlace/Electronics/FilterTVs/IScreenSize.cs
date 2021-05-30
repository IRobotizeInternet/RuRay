using System;

namespace RuRayFacebook.App.LoggedIn
{
    public interface IScreenSize<TScreenSize> where TScreenSize : struct, IConvertible
    {
        IApplyFilter ScreenSize(TScreenSize screenSize);
    }
}
