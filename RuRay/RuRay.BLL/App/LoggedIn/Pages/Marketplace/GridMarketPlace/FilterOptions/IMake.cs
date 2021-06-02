using System;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IMake{TMake}" />.
    /// </summary>
    /// <typeparam name="TMake">.</typeparam>
    public interface IMake<TMake> where TMake : struct, IConvertible
    {
        /// <summary>
        /// The Make.
        /// </summary>
        /// <param name="criteria">The criteria<see cref="TMake"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        IApplyFilter Make(TMake criteria);
    }
}
