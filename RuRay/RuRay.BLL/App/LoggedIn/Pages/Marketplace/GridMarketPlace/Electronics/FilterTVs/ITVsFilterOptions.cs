namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="ITVsFilterOptions" />.
    /// </summary>
    public interface ITVsFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandTVs>,
        IDisplayTechnology<DisplayTechnology>,
        IScreenSize<ScreenSize>
    {
    }
}
