using System;

namespace RuRayFacebook.App.LoggedIn
{
    public interface IFinish<TFinish> where TFinish : struct, IConvertible
    {
        IApplyFilter Finish(TFinish model);
    }
}