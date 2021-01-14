
namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IToolsFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandHomeGoodTools>
    {
    }
}
