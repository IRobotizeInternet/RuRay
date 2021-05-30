
namespace RuRayFacebook.App.LoggedIn
{
    public interface IRemoteControlToysFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandRemoteControlToys>
    {
    }
}
