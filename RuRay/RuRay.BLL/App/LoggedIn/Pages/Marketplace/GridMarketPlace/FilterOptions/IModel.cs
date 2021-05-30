using System;

namespace RuRayFacebook.App.LoggedIn
{
    public interface IModel<TModel> where TModel : struct, IConvertible
    {
        IApplyFilter Model(TModel model);
    }
}
