
namespace RobotizeFacebook.App.LoggedIn
{
    public interface IHousesForRentFilterOptions :
        IFilterOptions,
        ISortBy<PropertyRentalsSortOption>,
        IPrice
    {
    }
}
