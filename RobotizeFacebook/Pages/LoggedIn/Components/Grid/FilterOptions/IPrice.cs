namespace RobotizeFacebook.Grid
{
    public interface IPrice
    {
        IApplyFilter Price(double? min = null, double? max = null);
    }
}
