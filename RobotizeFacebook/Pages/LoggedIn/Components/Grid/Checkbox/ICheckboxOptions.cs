using System.Collections.Generic;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface ICheckboxOption: IFilterOptions, IFilter<ICheckboxFilterOptions>
    {
        IApplyFilter FilterItemList(IEnumerable<string> itemsToFilter);
    }
}
