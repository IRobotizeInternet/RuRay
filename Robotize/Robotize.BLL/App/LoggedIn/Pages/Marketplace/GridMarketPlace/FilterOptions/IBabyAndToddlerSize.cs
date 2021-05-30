using System;

namespace RuRayFacebook.App.LoggedIn
{
    public interface IBabyAndToddlerSize<TBabyAndToddlerSize> where TBabyAndToddlerSize : struct, IConvertible
    {
        IApplyFilter BabyAndToddlerSize(TBabyAndToddlerSize bodyStyle);
    }
}
