using System;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IBabyAndToddlerSize<TBabyAndToddlerSize> where TBabyAndToddlerSize : struct, IConvertible
    {
        IApplyFilter BabyAndToddlerSize(TBabyAndToddlerSize bodyStyle);
    }
}
