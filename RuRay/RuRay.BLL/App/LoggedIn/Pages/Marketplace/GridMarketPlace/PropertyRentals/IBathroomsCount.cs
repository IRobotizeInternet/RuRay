using System;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IBathroomsCount{TBathroomsCount}" />.
    /// </summary>
    /// <typeparam name="TBathroomsCount">.</typeparam>
    public interface IBathroomsCount<TBathroomsCount> where TBathroomsCount : struct, IConvertible
    {
        /// <summary>
        /// The Bedrooms.
        /// </summary>
        /// <param name="numberOfBedrooms">The numberOfBedrooms<see cref="TBathroomsCount"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        IApplyFilter Bedrooms(TBathroomsCount numberOfBedrooms);
    }
}
