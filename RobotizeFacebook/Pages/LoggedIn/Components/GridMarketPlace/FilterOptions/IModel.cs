using System;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IModel<TModel> where TModel : struct, IConvertible
    {
        IApplyFilter Model(TModel model);
    }
}
