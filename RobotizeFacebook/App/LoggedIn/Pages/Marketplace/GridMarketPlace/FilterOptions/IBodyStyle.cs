using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public interface IBodyStyle<TBodyStyle> where TBodyStyle: struct, IConvertible
    {
        IApplyFilter BodyStyle(TBodyStyle bodyStyle);        
    }
}
