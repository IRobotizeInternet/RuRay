namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="ICellPhoneAccessoriesFilterOptions" />.
    /// </summary>
    public interface ICellPhoneAccessoriesFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandCellPhoneAccesories>
    {
    }
}
