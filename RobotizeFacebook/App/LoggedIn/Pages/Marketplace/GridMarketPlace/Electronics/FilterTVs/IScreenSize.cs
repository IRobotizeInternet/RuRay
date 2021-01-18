using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public interface IScreenSize<TScreenSize> where TScreenSize : struct, IConvertible
    {
        IApplyFilter ScreenSize(TScreenSize screenSize);
    }
}
