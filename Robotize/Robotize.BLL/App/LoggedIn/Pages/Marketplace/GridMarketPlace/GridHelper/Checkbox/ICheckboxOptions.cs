using System.Collections.Generic;

namespace RuRayFacebook.App.LoggedIn
{
    public interface ICheckboxOption: IFilterOptions, IFilter<ICheckboxFilterOptions>
    {
        IApplyFilter FilterItemList(IEnumerable<string> itemsToFilter);
    }
}
