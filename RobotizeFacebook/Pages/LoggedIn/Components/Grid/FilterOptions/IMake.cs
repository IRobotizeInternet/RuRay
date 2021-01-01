using System;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IMake<TMake> where TMake : struct, IConvertible
    {
        IApplyFilter Make(TMake criteria);
    }
}
