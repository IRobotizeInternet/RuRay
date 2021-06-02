using System;

namespace RuRayFacebook.App.LoggedIn
{
    public interface IPlatform<TPlatform> where TPlatform : struct, IConvertible
    {
        IApparelFilter Platform(TPlatform platform);
    }
}
