namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IOutdoorCookingFilterOptions" />.
    /// </summary>
    public interface IOutdoorCookingFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandOutdoorCooking>
    {
    }
}
