using System;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IMaterial{TMaterial}" />.
    /// </summary>
    /// <typeparam name="TMaterial">.</typeparam>
    public interface IMaterial<TMaterial> where TMaterial : struct, IConvertible
    {
        /// <summary>
        /// The Material.
        /// </summary>
        /// <param name="material">The material<see cref="TMaterial"/>.</param>
        /// <returns>The <see cref="IFilterOptions"/>.</returns>
        IFilterOptions Material(TMaterial material);
    }
}
