using System;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IBedSize{TBedSize}" />.
    /// </summary>
    /// <typeparam name="TBedSize">.</typeparam>
    public interface IBedSize<TBedSize> where TBedSize : struct, IConvertible
    {
        /// <summary>
        /// The BedSize.
        /// </summary>
        /// <param name="bedSize">The bedSize<see cref="TBedSize"/>.</param>
        /// <returns>The <see cref="IFilterOptions"/>.</returns>
        IFilterOptions BedSize(TBedSize bedSize);
    }
}
