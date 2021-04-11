using System.Collections.Generic;

namespace RobotizeFacebook.App.LoggedIn
{
    public interface ICheckboxOption: IFilterOptions, IFilter<ICheckboxFilterOptions>
    {
        IApplyFilter FilterItemList(IEnumerable<string> itemsToFilter);
    }
}
