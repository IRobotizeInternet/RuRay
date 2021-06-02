using System;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IType{TType}" />.
    /// </summary>
    /// <typeparam name="TType">.</typeparam>
    public interface IType<TType> where TType : struct, IConvertible
    {
        /// <summary>
        /// The VehicleType.
        /// </summary>
        /// <param name="vehicleType">The vehicleType<see cref="TType"/>.</param>
        /// <returns>The <see cref="IFilterOptions"/>.</returns>
        IFilterOptions VehicleType(TType vehicleType);
    }
}
