namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="ILawnMowersFilterOptions" />.
    /// </summary>
    public interface ILawnMowersFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandLawnMowers>
    {
    }
}
