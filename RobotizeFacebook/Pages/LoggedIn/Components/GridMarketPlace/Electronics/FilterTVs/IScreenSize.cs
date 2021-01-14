using System;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IScreenSize<TScreenSize> where TScreenSize : struct, IConvertible
    {
        IApplyFilter ScreenSize(TScreenSize screenSize);
    }
}
