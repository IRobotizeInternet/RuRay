using System;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IPlatform{TPlatform}" />.
    /// </summary>
    /// <typeparam name="TPlatform">.</typeparam>
    public interface IPlatform<TPlatform> where TPlatform : struct, IConvertible
    {
        /// <summary>
        /// The Platform.
        /// </summary>
        /// <param name="platform">The platform<see cref="TPlatform"/>.</param>
        /// <returns>The <see cref="IApparelFilter"/>.</returns>
        IApparelFilter Platform(TPlatform platform);
    }
}
