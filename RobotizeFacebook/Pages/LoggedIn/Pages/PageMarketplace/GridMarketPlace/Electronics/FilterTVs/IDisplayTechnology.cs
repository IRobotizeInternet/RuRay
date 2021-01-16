using System;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IDisplayTechnology<TDisplayTechnology> where TDisplayTechnology : struct, IConvertible
    {
        IApplyFilter DisplayTechnology(TDisplayTechnology displayTechnology);
    }
}
