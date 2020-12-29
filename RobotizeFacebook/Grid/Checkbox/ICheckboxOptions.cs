using System.Collections.Generic;

namespace RobotizeFacebook.Grid
{
    public interface ICheckboxOption: IFilterOptions, IFilter<ICheckboxFilterOptions>
    {
        IApplyFilter FilterItemList(IEnumerable<string> itemsToFilter);
    }
}
