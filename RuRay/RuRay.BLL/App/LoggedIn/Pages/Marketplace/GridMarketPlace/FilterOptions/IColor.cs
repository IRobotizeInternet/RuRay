using System;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IColor{TExteriorColor}" />.
    /// </summary>
    /// <typeparam name="TExteriorColor">.</typeparam>
    public interface IColor<TExteriorColor> where TExteriorColor : struct, IConvertible
    {
        /// <summary>
        /// The ExteriorColor.
        /// </summary>
        /// <param name="exteriorColor">The exteriorColor<see cref="TExteriorColor"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        IApplyFilter ExteriorColor(TExteriorColor exteriorColor);
    }
}
