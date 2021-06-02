namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IGuitarsAndBassesFilterOptions" />.
    /// </summary>
    public interface IGuitarsAndBassesFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>
    {
    }
}
