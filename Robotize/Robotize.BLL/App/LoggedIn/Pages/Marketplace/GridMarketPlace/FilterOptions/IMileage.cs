namespace RobotizeFacebook.App.LoggedIn
{
    public interface IMileage: IFilterOptions
    {
        IApplyFilter Milage(double? min = null, double? max = null);
    }
}
