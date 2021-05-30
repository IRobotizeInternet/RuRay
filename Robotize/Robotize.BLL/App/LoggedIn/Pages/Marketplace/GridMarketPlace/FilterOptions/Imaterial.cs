using System;

namespace RuRayFacebook.App.LoggedIn
{
    public interface IMaterial<TMaterial> where TMaterial : struct, IConvertible
    {
        IFilterOptions Material(TMaterial material);
    }
}
