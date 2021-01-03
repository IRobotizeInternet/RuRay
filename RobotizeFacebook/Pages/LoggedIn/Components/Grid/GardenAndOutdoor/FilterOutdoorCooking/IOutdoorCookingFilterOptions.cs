
namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IOutdoorCookingFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandOutdoorCooking>
    {
    }
}
