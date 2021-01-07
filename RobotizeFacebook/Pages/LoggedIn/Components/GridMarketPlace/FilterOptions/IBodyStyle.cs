using System;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IBodyStyle<TBodyStyle> where TBodyStyle: struct, IConvertible
    {
        IApplyFilter BodyStyle(TBodyStyle bodyStyle);        
    }
}
