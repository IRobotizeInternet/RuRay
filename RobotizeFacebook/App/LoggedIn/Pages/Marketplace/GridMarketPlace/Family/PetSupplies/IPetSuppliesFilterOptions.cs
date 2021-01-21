
namespace RobotizeFacebook.App.LoggedIn
{
    public interface IPetSuppliesFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandPetSupply>
    {
    }
}
