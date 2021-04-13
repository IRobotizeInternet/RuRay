
namespace RobotizeFacebook.App.LoggedIn
{
    public interface ITownhousesForRentFilterOptions :
        IFilterOptions,
        ISortBy<PropertyRentalsSortOption>,
        IPrice
    {
    }
}
