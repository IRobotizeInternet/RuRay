
namespace RobotizeFacebook.Grid
{
    public interface IHousesForRentFilterOptions : 
        IFilterOptions,
        ISortBy<VehicleSortOption>,
        IPrice,
        IBedroomsCount<BathroomCount>,
        IBathroomsCount<BathroomCount>,
        IRentalType<RentalType>
    {
    }
}
