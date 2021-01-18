using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public interface IModel<TModel> where TModel : struct, IConvertible
    {
        IApplyFilter Model(TModel model);
    }
}
