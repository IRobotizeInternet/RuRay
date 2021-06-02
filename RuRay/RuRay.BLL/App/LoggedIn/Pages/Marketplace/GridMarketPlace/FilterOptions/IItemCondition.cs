using System;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IItemCondition{TITemCondition}" />.
    /// </summary>
    /// <typeparam name="TITemCondition">.</typeparam>
    public interface IItemCondition<TITemCondition> where TITemCondition : struct, IConvertible
    {
        /// <summary>
        /// The ItemCondition.
        /// </summary>
        /// <param name="condition">The condition<see cref="TITemCondition"/>.</param>
        /// <returns>The <see cref="IFilterOptions"/>.</returns>
        IFilterOptions ItemCondition(TITemCondition condition);
    }
}
