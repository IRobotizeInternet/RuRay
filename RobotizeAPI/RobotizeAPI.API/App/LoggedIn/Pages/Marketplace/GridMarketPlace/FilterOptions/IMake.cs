using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public interface IMake<TMake> where TMake : struct, IConvertible
    {
        IApplyFilter Make(TMake criteria);
    }
}
