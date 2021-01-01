
namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IHousesForRentFilterOptions :
        IFilterOptions,
        ISortBy<PropertyRentalsSortOption>,
        IPrice
    {
    }
}
