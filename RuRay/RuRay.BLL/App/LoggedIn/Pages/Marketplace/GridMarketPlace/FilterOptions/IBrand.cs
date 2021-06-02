using System;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IBrand{TBrand}" />.
    /// </summary>
    /// <typeparam name="TBrand">.</typeparam>
    public interface IBrand<TBrand> where TBrand : struct, IConvertible
    {
        /// <summary>
        /// The Brand.
        /// </summary>
        /// <param name="bodyStyle">The bodyStyle<see cref="TBrand"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        IApplyFilter Brand(TBrand bodyStyle);
    }
}
