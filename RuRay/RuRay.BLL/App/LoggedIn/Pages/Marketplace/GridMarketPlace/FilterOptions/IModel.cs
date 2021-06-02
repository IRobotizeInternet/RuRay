using System;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IModel{TModel}" />.
    /// </summary>
    /// <typeparam name="TModel">.</typeparam>
    public interface IModel<TModel> where TModel : struct, IConvertible
    {
        /// <summary>
        /// The Model.
        /// </summary>
        /// <param name="model">The model<see cref="TModel"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        IApplyFilter Model(TModel model);
    }
}
