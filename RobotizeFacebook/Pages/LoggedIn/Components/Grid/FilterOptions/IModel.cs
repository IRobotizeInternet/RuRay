using System;

namespace RobotizeFacebook.Grid
{
    public interface IModel<TModel> where TModel : struct, IConvertible
    {
        IApplyFilter Model(TModel model);
    }
}
