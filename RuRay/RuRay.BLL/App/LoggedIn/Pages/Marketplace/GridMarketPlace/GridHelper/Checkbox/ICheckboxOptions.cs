using System.Collections.Generic;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="ICheckboxOption" />.
    /// </summary>
    public interface ICheckboxOption : IFilterOptions, IFilter<ICheckboxFilterOptions>
    {
        /// <summary>
        /// The FilterItemList.
        /// </summary>
        /// <param name="itemsToFilter">The itemsToFilter<see cref="IEnumerable{string}"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        IApplyFilter FilterItemList(IEnumerable<string> itemsToFilter);
    }
}
