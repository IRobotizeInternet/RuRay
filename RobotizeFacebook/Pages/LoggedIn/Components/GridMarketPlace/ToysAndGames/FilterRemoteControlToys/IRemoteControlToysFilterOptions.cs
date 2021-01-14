
namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IRemoteControlToysFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandRemoteControlToys>
    {
    }
}
