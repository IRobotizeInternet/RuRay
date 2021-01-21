
namespace RobotizeFacebook.App.LoggedIn
{
    public interface IBabyClothingFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBabyAndToddlerSize<BabyAndToddlerSize>
    {
    }
}
