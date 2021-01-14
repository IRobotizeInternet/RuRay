
namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface ILawnMowersFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandLawnMowers>
    {
    }
}
