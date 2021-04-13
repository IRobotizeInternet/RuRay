
namespace RobotizeFacebook.App.LoggedIn
{
    public interface IToolsFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandHomeGoodTools>
    {
    }
}
