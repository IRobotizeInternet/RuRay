namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IPrice
    {
        IApplyFilter Price(double? min = null, double? max = null);
    }
}
