
namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IHomeGoodsToolsFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandHomeGoodTools>
    {
    }
}
