
namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IBabyClothingFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBabyAndToddlerSize<BabyAndToddlerSize>
    {
    }
}
