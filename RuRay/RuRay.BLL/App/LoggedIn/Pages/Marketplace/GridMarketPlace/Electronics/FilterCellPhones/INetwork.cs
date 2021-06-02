using System;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="INetwork{TNetwork}" />.
    /// </summary>
    /// <typeparam name="TNetwork">.</typeparam>
    public interface INetwork<TNetwork> where TNetwork : struct, IConvertible
    {
        /// <summary>
        /// The Network.
        /// </summary>
        /// <param name="network">The network<see cref="TNetwork"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        IApplyFilter Network(TNetwork network);
    }
}
