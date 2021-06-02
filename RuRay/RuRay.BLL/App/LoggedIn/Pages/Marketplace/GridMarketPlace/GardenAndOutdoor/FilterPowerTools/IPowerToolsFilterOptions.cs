namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IPowerToolsFilterOptions" />.
    /// </summary>
    public interface IPowerToolsFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandPowerTools>
    {
    }
}
