using System;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IFinish{TFinish}" />.
    /// </summary>
    /// <typeparam name="TFinish">.</typeparam>
    public interface IFinish<TFinish> where TFinish : struct, IConvertible
    {
        /// <summary>
        /// The Finish.
        /// </summary>
        /// <param name="model">The model<see cref="TFinish"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        IApplyFilter Finish(TFinish model);
    }
}
