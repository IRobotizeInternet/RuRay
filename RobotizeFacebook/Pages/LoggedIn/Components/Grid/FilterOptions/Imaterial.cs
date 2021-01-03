using System;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IMaterial<TMaterial> where TMaterial : struct, IConvertible
    {
        IFilterOptions Material(TMaterial material);
    }
}
