namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IBabyAndKidsItemsFilterOptions" />.
    /// </summary>
    public interface IBabyAndKidsItemsFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>
    {
    }
}
