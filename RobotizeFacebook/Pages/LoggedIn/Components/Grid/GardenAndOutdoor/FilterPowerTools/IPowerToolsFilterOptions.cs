
namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IPowerToolsFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandPowerTools>
    {
    }
}
