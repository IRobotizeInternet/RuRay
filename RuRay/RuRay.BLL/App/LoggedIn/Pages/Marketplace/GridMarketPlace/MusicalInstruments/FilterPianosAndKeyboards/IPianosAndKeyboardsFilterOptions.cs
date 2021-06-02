namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IPianosAndKeyboardsFilterOptions" />.
    /// </summary>
    public interface IPianosAndKeyboardsFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>
    {
    }
}
