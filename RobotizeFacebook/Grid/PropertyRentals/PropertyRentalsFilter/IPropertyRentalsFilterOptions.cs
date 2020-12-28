
namespace RobotizeFacebook.Grid
{
    public interface IPropertyRentalsFilterOptions : 
        IFilterOptions,
        ISortBy<VehicleSortOption>,
        IPrice,
        IBedroomsCount<BathroomCount>,
        IBathroomsCount<BathroomCount>,
        IRentalType<RentalType>
    {
    }
}
