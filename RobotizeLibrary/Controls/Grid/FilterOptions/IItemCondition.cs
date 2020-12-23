using System;

namespace RobotizeLibrary.Controls.Grid
{
    public interface IItemCondition<TITemCondition> where TITemCondition : struct, IConvertible
    {
        IFilterOptions ItemCondition(TITemCondition vehicleType);
    }
}
