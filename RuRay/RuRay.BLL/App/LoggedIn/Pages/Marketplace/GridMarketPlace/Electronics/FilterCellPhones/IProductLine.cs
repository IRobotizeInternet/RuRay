using System;

namespace RuRayFacebook.App.LoggedIn
{
    public interface IProductLine<TProductLine> where TProductLine : struct, IConvertible
    {
        IApplyFilter ProductLine(TProductLine productLine);
    }
}
