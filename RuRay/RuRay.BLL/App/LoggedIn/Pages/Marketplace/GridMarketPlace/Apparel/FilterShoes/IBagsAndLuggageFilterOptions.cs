
namespace RuRayFacebook.App.LoggedIn
{
    public interface IBagsAndLuggageFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandBagsAndLuggage>
    {
    }
}
