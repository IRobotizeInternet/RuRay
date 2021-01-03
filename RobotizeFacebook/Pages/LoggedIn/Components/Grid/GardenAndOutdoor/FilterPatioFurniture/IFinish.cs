using System;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IFinish<TFinish> where TFinish : struct, IConvertible
    {
        IApplyFilter Finish(TFinish model);
    }
}