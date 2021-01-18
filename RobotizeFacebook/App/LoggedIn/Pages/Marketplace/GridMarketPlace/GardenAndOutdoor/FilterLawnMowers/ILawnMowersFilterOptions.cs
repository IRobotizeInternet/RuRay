
namespace RobotizeFacebook.App.LoggedIn
{
    public interface ILawnMowersFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandLawnMowers>
    {
    }
}
