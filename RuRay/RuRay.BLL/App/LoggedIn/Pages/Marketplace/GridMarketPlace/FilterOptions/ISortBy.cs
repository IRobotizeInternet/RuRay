using System;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="ISortBy{TSortType}" />.
    /// </summary>
    /// <typeparam name="TSortType">.</typeparam>
    public interface ISortBy<TSortType> where TSortType : struct, IConvertible
    {
        /// <summary>
        /// The SortBy.
        /// </summary>
        /// <param name="criteria">The criteria<see cref="TSortType"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        IApplyFilter SortBy(TSortType criteria);
    }
}
