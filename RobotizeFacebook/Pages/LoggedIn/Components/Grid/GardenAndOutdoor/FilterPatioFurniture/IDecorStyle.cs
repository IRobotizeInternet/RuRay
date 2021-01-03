using System;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IDecorStyle<TDecorStyle> where TDecorStyle : struct, IConvertible
    {
        IApplyFilter DecorStyle(TDecorStyle model);
    }
}