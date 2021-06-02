using System;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IBodyStyle{TBodyStyle}" />.
    /// </summary>
    /// <typeparam name="TBodyStyle">.</typeparam>
    public interface IBodyStyle<TBodyStyle> where TBodyStyle : struct, IConvertible
    {
        /// <summary>
        /// The BodyStyle.
        /// </summary>
        /// <param name="bodyStyle">The bodyStyle<see cref="TBodyStyle"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        IApplyFilter BodyStyle(TBodyStyle bodyStyle);
    }
}
