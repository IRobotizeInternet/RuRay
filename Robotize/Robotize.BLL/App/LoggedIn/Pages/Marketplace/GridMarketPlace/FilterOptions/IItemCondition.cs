using System;

namespace RuRayFacebook.App.LoggedIn
{
    public interface IItemCondition<TITemCondition> where TITemCondition : struct, IConvertible
    {
        IFilterOptions ItemCondition(TITemCondition condition);
    }
}
