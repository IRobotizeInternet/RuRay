
namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IJewelryAndAccessoriesFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandJewelryAndAccessories>,
        IMaterial<MaterialJewelryAndAccessories>
    {
    }
}
