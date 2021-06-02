namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IKidsClothingFilterOptions" />.
    /// </summary>
    public interface IKidsClothingFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandKidsClothing>
    {
    }
}
