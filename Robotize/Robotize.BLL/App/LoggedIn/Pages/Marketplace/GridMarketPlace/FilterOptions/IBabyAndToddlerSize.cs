using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public interface IBabyAndToddlerSize<TBabyAndToddlerSize> where TBabyAndToddlerSize : struct, IConvertible
    {
        IApplyFilter BabyAndToddlerSize(TBabyAndToddlerSize bodyStyle);
    }
}
