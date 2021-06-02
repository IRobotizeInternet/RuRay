namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IShowersAndShowerPartsFilterOptions" />.
    /// </summary>
    public interface IShowersAndShowerPartsFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>
    {
    }
}
