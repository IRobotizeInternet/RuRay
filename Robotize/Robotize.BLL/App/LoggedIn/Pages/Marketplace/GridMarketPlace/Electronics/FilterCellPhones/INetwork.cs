using System;

namespace RuRayFacebook.App.LoggedIn
{
    public interface INetwork<TNetwork> where TNetwork : struct, IConvertible
    {
        IApplyFilter Network(TNetwork network);
    }
}
