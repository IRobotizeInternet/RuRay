namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IBagsAndLuggageFilterOptions" />.
    /// </summary>
    public interface IBagsAndLuggageFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandBagsAndLuggage>
    {
    }
}
