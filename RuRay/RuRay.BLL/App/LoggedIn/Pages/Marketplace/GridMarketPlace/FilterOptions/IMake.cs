using System;

namespace RuRayFacebook.App.LoggedIn
{
    public interface IMake<TMake> where TMake : struct, IConvertible
    {
        IApplyFilter Make(TMake criteria);
    }
}
