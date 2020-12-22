using System;

namespace RobotizeLibrary.Controls.Grid
{
    public interface IBodyStyle<TBodyStyle> where TBodyStyle: struct, IConvertible
    {
        IApplyFilter BodyStyle(TBodyStyle bodyStyle);        
    }
}
