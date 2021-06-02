using System;

namespace RuRayFacebook.App.LoggedIn.Components.Grid.Electronics.FilterTVs
{
    /// <summary>
    /// Defines the <see cref="IFeature{TFeature}" />.
    /// </summary>
    /// <typeparam name="TFeature">.</typeparam>
    public interface IFeature<TFeature> where TFeature : struct, IConvertible
    {
        /// <summary>
        /// The Feature.
        /// </summary>
        /// <param name="feature">The feature<see cref="TFeature"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        IApplyFilter Feature(TFeature feature);
    }
}
