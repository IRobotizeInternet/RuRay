
namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface ICellPhoneAccessoriesFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandCellPhoneAccesories>
    {
    }
}
