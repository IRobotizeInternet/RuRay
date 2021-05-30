
namespace RuRayFacebook.App.LoggedIn
{
    public interface ICamerasFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandCamera>
    {
    }
}
