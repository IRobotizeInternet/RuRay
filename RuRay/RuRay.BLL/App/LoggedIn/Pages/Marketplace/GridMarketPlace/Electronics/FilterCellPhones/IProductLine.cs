using System;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IProductLine{TProductLine}" />.
    /// </summary>
    /// <typeparam name="TProductLine">.</typeparam>
    public interface IProductLine<TProductLine> where TProductLine : struct, IConvertible
    {
        /// <summary>
        /// The ProductLine.
        /// </summary>
        /// <param name="productLine">The productLine<see cref="TProductLine"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        IApplyFilter ProductLine(TProductLine productLine);
    }
}
