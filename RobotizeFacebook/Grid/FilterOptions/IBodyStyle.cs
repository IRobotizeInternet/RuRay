using System;

namespace RobotizeFacebook.Grid
{
    public interface IBodyStyle<TBodyStyle> where TBodyStyle: struct, IConvertible
    {
        IApplyFilter BodyStyle(TBodyStyle bodyStyle);        
    }
}
