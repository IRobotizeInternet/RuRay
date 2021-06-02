namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IPetSuppliesFilterOptions" />.
    /// </summary>
    public interface IPetSuppliesFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandPetSupply>
    {
    }
}
