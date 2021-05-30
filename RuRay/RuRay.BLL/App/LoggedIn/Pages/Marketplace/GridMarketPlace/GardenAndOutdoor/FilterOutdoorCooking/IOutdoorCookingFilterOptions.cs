
namespace RuRayFacebook.App.LoggedIn
{
    public interface IOutdoorCookingFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandOutdoorCooking>
    {
    }
}
