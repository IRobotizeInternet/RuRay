using System;

namespace RobotizeFacebook.Grid
{
    public interface IItemCondition<TITemCondition> where TITemCondition : struct, IConvertible
    {
        IFilterOptions ItemCondition(TITemCondition vehicleType);
    }
}
