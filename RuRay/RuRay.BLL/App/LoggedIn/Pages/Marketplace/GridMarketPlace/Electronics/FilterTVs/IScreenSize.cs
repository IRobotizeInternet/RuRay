using System;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IScreenSize{TScreenSize}" />.
    /// </summary>
    /// <typeparam name="TScreenSize">.</typeparam>
    public interface IScreenSize<TScreenSize> where TScreenSize : struct, IConvertible
    {
        /// <summary>
        /// The ScreenSize.
        /// </summary>
        /// <param name="screenSize">The screenSize<see cref="TScreenSize"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        IApplyFilter ScreenSize(TScreenSize screenSize);
    }
}
