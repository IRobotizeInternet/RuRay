namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IHomeAutomationSystemsFilterOptions" />.
    /// </summary>
    public interface IHomeAutomationSystemsFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>
    {
    }
}
