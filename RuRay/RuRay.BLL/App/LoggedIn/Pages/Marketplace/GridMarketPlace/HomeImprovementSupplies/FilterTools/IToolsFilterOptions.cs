namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IToolsFilterOptions" />.
    /// </summary>
    public interface IToolsFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandHomeGoodTools>
    {
    }
}
