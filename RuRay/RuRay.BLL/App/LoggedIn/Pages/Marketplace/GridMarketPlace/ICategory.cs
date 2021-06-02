using System;
using System.Collections.Generic;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="ICategory{TCategoryType}" />.
    /// </summary>
    /// <typeparam name="TCategoryType">.</typeparam>
    public interface ICategory<TCategoryType> where TCategoryType : struct, IConvertible
    {
        /// <summary>
        /// The Category.
        /// </summary>
        /// <param name="category">The category<see cref="TCategoryType"/>.</param>
        void Category(TCategoryType category);

        /// <summary>
        /// The GetAllCategories.
        /// </summary>
        /// <returns>The <see cref="IEnumerable{string}"/>.</returns>
        IEnumerable<string> GetAllCategories();
    }
}
