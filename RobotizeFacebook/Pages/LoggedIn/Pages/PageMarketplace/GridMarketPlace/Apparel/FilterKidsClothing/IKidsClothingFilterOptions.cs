
namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IKidsClothingFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandKidsClothing>
    {
    }
}
