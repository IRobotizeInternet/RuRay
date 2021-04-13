
namespace RobotizeFacebook.App.LoggedIn
{
    public interface IPowerToolsFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandPowerTools>
    {
    }
}
