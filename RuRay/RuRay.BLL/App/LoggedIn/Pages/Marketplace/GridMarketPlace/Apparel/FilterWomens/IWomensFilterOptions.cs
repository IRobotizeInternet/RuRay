namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IWomensFilterOptions" />.
    /// </summary>
    public interface IWomensFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IColor<ColorWomenApparel>
    {
    }
}
