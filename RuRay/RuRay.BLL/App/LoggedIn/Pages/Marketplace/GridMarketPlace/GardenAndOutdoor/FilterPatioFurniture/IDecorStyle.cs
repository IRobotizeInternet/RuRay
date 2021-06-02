using System;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IDecorStyle{TDecorStyle}" />.
    /// </summary>
    /// <typeparam name="TDecorStyle">.</typeparam>
    public interface IDecorStyle<TDecorStyle> where TDecorStyle : struct, IConvertible
    {
        /// <summary>
        /// The DecorStyle.
        /// </summary>
        /// <param name="model">The model<see cref="TDecorStyle"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        IApplyFilter DecorStyle(TDecorStyle model);
    }
}
