
namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IPetSuppliesFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandPetSupply>
    {
    }
}
