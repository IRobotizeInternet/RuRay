namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IKitchenAndDiningProductsFilterOptions" />.
    /// </summary>
    public interface IKitchenAndDiningProductsFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>
    {
    }
}
