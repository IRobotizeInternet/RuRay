using System;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IBedroomsCount{TBedroomCount}" />.
    /// </summary>
    /// <typeparam name="TBedroomCount">.</typeparam>
    public interface IBedroomsCount<TBedroomCount> where TBedroomCount : struct, IConvertible
    {
        /// <summary>
        /// The Bedrooms.
        /// </summary>
        /// <param name="numberOfBedrooms">The numberOfBedrooms<see cref="TBedroomCount"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        IApplyFilter Bedrooms(TBedroomCount numberOfBedrooms);
    }
}
