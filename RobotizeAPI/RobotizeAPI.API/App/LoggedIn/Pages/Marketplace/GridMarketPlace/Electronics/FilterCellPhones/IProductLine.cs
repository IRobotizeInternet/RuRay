using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public interface IProductLine<TProductLine> where TProductLine : struct, IConvertible
    {
        IApplyFilter ProductLine(TProductLine productLine);
    }
}
