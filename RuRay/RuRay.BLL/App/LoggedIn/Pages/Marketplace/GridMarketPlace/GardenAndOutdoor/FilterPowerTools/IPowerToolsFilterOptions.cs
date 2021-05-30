
namespace RuRayFacebook.App.LoggedIn
{
    public interface IPowerToolsFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandPowerTools>
    {
    }
}
