using System;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IItemCondition<TITemCondition> where TITemCondition : struct, IConvertible
    {
        IFilterOptions ItemCondition(TITemCondition vehicleType);
    }
}
