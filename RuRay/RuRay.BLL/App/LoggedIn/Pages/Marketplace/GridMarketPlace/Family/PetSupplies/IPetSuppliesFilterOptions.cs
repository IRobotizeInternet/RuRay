
namespace RuRayFacebook.App.LoggedIn
{
    public interface IPetSuppliesFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandPetSupply>
    {
    }
}
