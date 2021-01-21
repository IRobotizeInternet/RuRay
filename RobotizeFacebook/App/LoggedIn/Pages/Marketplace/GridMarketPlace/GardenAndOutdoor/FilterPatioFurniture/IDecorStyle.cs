using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public interface IDecorStyle<TDecorStyle> where TDecorStyle : struct, IConvertible
    {
        IApplyFilter DecorStyle(TDecorStyle model);
    }
}