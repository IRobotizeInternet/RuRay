
namespace RobotizeFacebook.App.LoggedIn
{
    public interface IRemoteControlToysFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandRemoteControlToys>
    {
    }
}
