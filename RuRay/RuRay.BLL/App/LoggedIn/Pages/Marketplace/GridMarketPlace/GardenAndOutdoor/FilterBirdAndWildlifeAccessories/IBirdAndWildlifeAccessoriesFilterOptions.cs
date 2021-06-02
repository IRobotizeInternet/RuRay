namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IBirdAndWildlifeAccessoriesFilterOptions" />.
    /// </summary>
    public interface IBirdAndWildlifeAccessoriesFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>
    {
    }
}
