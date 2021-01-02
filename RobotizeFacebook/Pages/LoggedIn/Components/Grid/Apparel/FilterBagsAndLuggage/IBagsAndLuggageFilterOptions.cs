
namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IBagsAndLuggageFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandBagsAndLuggage>
    {
    }
}
