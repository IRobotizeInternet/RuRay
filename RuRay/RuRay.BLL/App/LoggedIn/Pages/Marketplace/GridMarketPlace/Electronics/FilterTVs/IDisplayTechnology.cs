using System;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IDisplayTechnology{TDisplayTechnology}" />.
    /// </summary>
    /// <typeparam name="TDisplayTechnology">.</typeparam>
    public interface IDisplayTechnology<TDisplayTechnology> where TDisplayTechnology : struct, IConvertible
    {
        /// <summary>
        /// The DisplayTechnology.
        /// </summary>
        /// <param name="displayTechnology">The displayTechnology<see cref="TDisplayTechnology"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        IApplyFilter DisplayTechnology(TDisplayTechnology displayTechnology);
    }
}
