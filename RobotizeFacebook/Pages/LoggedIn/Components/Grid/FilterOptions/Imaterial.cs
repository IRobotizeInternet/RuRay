using System;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface Imaterial<TMaterial> where TMaterial : struct, IConvertible
    {
        IFilterOptions Material(TMaterial material);
    }
}
