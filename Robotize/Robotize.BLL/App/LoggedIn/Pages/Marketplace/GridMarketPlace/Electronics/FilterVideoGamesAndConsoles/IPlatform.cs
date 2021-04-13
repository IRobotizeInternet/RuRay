using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public interface IPlatform<TPlatform> where TPlatform: struct, IConvertible
    {
        IApparelFilter Platform(TPlatform platform);
    }
}
