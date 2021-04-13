using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public interface IMaterial<TMaterial> where TMaterial : struct, IConvertible
    {
        IFilterOptions Material(TMaterial material);
    }
}
