using System;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IPlatform<TPlatform> where TPlatform: struct, IConvertible
    {
        IApparelFilter Platform(TPlatform platform);
    }
}
