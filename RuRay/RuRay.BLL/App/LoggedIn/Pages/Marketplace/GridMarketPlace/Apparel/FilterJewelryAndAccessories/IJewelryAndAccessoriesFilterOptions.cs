namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IJewelryAndAccessoriesFilterOptions" />.
    /// </summary>
    public interface IJewelryAndAccessoriesFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandJewelryAndAccessories>,
        IMaterial<MaterialJewelryAndAccessories>
    {
    }
}
