namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="ICellPhonesFilterOptions" />.
    /// </summary>
    public interface ICellPhonesFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandCamera>,
        INetwork<Network>,
        IProductLine<ProductLine>
    {
    }
}
