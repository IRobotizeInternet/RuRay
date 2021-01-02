using System;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface INetwork<TNetwork> where TNetwork : struct, IConvertible
    {
        IApplyFilter Network(TNetwork network);
    }
}
