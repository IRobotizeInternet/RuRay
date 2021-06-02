using System;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IRentalType{TRentalType}" />.
    /// </summary>
    /// <typeparam name="TRentalType">.</typeparam>
    public interface IRentalType<TRentalType> where TRentalType : struct, IConvertible
    {
        /// <summary>
        /// The RentalType.
        /// </summary>
        /// <param name="numberOfBedrooms">The numberOfBedrooms<see cref="TRentalType"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        IApplyFilter RentalType(TRentalType numberOfBedrooms);
    }
}
