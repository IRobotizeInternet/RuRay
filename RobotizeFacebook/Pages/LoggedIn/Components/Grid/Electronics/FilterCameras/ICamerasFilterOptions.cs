
namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface ICamerasFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandCamera>
    {
    }
}
